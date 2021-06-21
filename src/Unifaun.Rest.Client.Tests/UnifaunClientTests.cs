using System;
using System.Threading.Tasks;
using Unifaun.Rest.Client.Models.StoredShipments;
using Xunit;

namespace Unifaun.Rest.Client.Tests
{
    public class UnifaunClientTests : UnifaunBaseTest
    {
        [Fact]
        public void SerializeJsonToString_Test()
        {
            var data = new StoredShipmentRequest
            {
                Sender = new Sender
                {
                    City = "Skellefteå"
                }
            };

            var jsonData = UnifaunRestClient.SerializeJsonToString(data);
        }

        [Fact]
        public void DeserializeJsonToString_Test()
        {
            var jsonString = @"{
    ""href"": ""https://api.unifaun.com/ufoweb-prod-202101041406/rs-extapi/v1/stored-shipments/9999999"",
    ""id"": ""9999999"",
    ""status"": ""READY"",
    ""orderNo"": null,
    ""reference"": null,
    ""serviceId"": ""P17"",
    ""parcelCount"": 1,
    ""sndName"": ""Bolaget AB"",
    ""sndZipcode"": ""93134"",
    ""sndCity"": ""SKELLEFTEÅ"",
    ""sndCountry"": ""SE"",
    ""rcvName"": ""Anders Svensson"",
    ""rcvZipcode"": ""93134"",
    ""rcvCity"": ""SKELLEFTEÅ"",
    ""rcvCountry"": ""SE"",
    ""created"": ""2021-01-04T22:51:58.048+0000"",
    ""changed"": ""2021-01-04T22:51:58.048+0000"",
    ""shipDate"": ""2021-01-04T22:51:57.674+0000"",
    ""returnShipment"": false,
    ""normalShipment"": true,
    ""profileGroup"": ""Grundprofilgrupp"",
    ""statuses"": null,
    ""addons"": []
}";
            var response = UnifaunRestClient.DeserializeJson<StoredShipmentResponse>(jsonString);

            Assert.Equal(new DateTimeOffset(2021, 1, 04, 22, 51, 58, 48, new TimeSpan()), response.Created);
            Assert.Equal("13642394", response.Id);
            Assert.Equal(false, response.ReturnShipment);
            Assert.Equal(true, response.NormalShipment);
            Assert.Equal(1L, response.ParcelCount);
            Assert.Equal("READY", response.Status);
        }

        [Fact]
        public async Task CreateStoredShipment_Test()
        {

            var data = new StoredShipmentRequest
            {
                Sender = new Sender
                {
                    QuickId = "1"
                },
                Receiver = new Receiver
                {
                    Name = "Anders Svensson",
                    Address1 = "Kanalgatan 77",
                    Zipcode = "93134",
                    City = "Skellefteå",
                    Country = "SE",
                    Mobile = "0701234567"
                },
                Service = new Service
                {
                    Id = "P17"
                }
            };

            var response = await this.Client.CreateStoredShipment(data);

            Assert.Equal("READY", response.Status);
        }
    }
}
