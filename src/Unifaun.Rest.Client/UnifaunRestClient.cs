using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Unifaun.Rest.Client.Models;
using Unifaun.Rest.Client.Models.DeliveryCheckout;
using Unifaun.Rest.Client.Models.Meta;
using Unifaun.Rest.Client.Models.Price;
using Unifaun.Rest.Client.Models.StoredShipments;

namespace Unifaun.Rest.Client
{
    public class UnifaunRestClient
    {
        private const string BaseUrl = "https://api.unifaun.com/rs-extapi/v1";

        public string ApiKey { get; set; }

        public HttpClient HttpClient => new HttpClient();

        private static JsonSerializerOptions UnifaunSerializerOptions
        {
            get
            {
                var options = new JsonSerializerOptions { IgnoreNullValues = true };
                options.Converters.Add(new DateTimeOffsetConverter());
                options.Converters.Add(new NullableDateTimeOffsetConverter());
                return options;
            }
        }

        #region Methods

        public async Task<StoredShipmentResponse> CreateStoredShipment(StoredShipmentRequest request)
        {
            return await Request<StoredShipmentRequest, StoredShipmentResponse>("/stored-shipments", request, httpMethod: HttpMethod.Post);
        }

        public async Task<Partner[]> Partners(string language)
        {
            return await GetRequest<Partner[]>("/meta/lists/partners", new Dictionary<string, object> { { "language", language } });
        }

        public async Task<string> PartnersJson(string language)
        {
            return await GetRequest<string>("/meta/lists/partners", new Dictionary<string, object> { { "language", language } });
        }

        public async Task<DeliveryCheckoutResponse> DeliveryCheckout(
            string deliveryCheckoutId, string currency, string language, string toCountry, 
            string toZipCode, string toState = null, decimal? weight = null, decimal? cartprice = null, IDictionary<string, object> additionalParameters = null)
        {
            var param = new Dictionary<string, object>
            {
                {"currency", currency},
                {"language", language},
                {"tocountry", toCountry},
                {"tozipcode", toZipCode},
                {"tostate", toState},
                {"weight", weight},
                {"cartprice", cartprice}
            };

            if (additionalParameters != null)
            {
                foreach (var additionalParameter in additionalParameters)
                {
                    param.Add(additionalParameter.Key, additionalParameter.Value);
                }
            }

            return await GetRequest<DeliveryCheckoutResponse>($"/delivery-checkouts/{deliveryCheckoutId}", param);
        }

        public async Task<PriceResponse> Prices(PriceRequest request)
        {
            return await Request<PriceRequest, PriceResponse>("/prices", request);
        }

        #endregion

        #region Helpers

        private async Task<TResponse> Request<TRequest, TResponse>(string path, TRequest body = null, IDictionary<string, object> query = null, HttpMethod httpMethod = null)
            where TRequest : class
            where TResponse : class
        {
            using (var request = new HttpRequestMessage())
            {
                SetHeader(request);

                request.Method = httpMethod ?? HttpMethod.Post;
                request.RequestUri = CreateUri(path, query);

                if (body != null)
                {
                    var bodyContent = SerializeJsonToString(body);
                    request.Content = new StringContent(bodyContent, Encoding.UTF8, "application/json");
                }

                var response = await HttpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);

                await HandleResponse(response);

                return await ReadJsonContentTo<TResponse>(response);
            }
        }

        private static async Task HandleResponse(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                try
                {
                    if ((int) response.StatusCode == 422)
                    {

                        var fieldErrors = await ReadJsonContentAsStringTo<FieldError[]>(response);
                        throw new Exception(string.Join(",", fieldErrors.Select(e => $"{e.Location} {e.Field} {e.Type}: {e.Message}")));
                    }

                    var errorResponse = await ReadJsonContentAsStringTo<ErrorResponse>(response);
                    throw new Exception(errorResponse?.Message ?? response.StatusCode.ToString());
                }
                catch (Exception e)
                {
                    throw new Exception($"{response.StatusCode}: {e.Message}", e);
                }
            }
        }

        private async Task<TResponse> GetRequest<TResponse>(string path, IDictionary<string, object> query = null)
        {
            using (var request = new HttpRequestMessage())
            {
                SetHeader(request);
                request.Method = new HttpMethod("GET");
                request.RequestUri = CreateUri(path, query);

                var response = await HttpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);

                if (typeof(TResponse) == typeof(string))
                {
                    var stringResponse = await ReadContentToString(response);

                    return (TResponse)Convert.ChangeType(stringResponse, typeof(TResponse));
                }

                return await ReadJsonContentTo<TResponse>(response);
            }
        }

        public static string SerializeJsonToString<T>(T value)
        {
            return JsonSerializer.Serialize(value, UnifaunSerializerOptions);
        }

        public static T DeserializeJson<T>(string jsonData)
        {
            return JsonSerializer.Deserialize<T>(jsonData, UnifaunSerializerOptions);
        }

        private static Uri CreateUri(string path, IDictionary<string, object> query)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl).Append(path);

            if (query != null)
                urlBuilder.Append("?").Append(string.Join("&", query
                    .Where(q => q.Value != null)
                    .Select(q => $"{WebUtility.HtmlEncode(q.Key)}={WebUtility.HtmlEncode(string.Format(CultureInfo.InvariantCulture, "{0}", q.Value))}")));

            var url = urlBuilder.ToString();
            return new Uri(url);
        }

        private static async Task<TResponse> ReadJsonContentTo<TResponse>(HttpResponseMessage response)
        {
            if (response.Content == null)
                return default;

            using (var responseStream = await response.Content.ReadAsStreamAsync())
            {
                return await JsonSerializer.DeserializeAsync<TResponse>(responseStream, UnifaunSerializerOptions);
            }
        }

        private static async Task<TResponse> ReadJsonContentAsStringTo<TResponse>(HttpResponseMessage response)
        {
            if (response.Content == null)
                return default;

            var responseContent = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(responseContent))
                return default;

            try
            {
                return JsonSerializer.Deserialize<TResponse>(responseContent, UnifaunSerializerOptions);
            }
            catch (Exception e)
            {
                throw new Exception($"Could not parse {responseContent} to {typeof(TResponse).Name}: {e.Message}", e);
            }
        }

        private static async Task<string> ReadContentToString(HttpResponseMessage response)
        {
            if (response.Content == null)
                return null;

            return await response.Content.ReadAsStringAsync();
        }

        private void SetHeader(HttpRequestMessage request)
        {
            //var byteArray = Encoding.ASCII.GetBytes($"{this.ApiKey}:{this.SecretId}");
            //request.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", this.ApiKey);
            request.Headers.TryAddWithoutValidation("Accept", "application/json");
        }

        #endregion
    }
}
