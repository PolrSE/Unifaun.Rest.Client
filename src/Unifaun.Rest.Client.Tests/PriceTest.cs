using System.Threading.Tasks;
using Unifaun.Rest.Client.Models.Price;
using Unifaun.Rest.Client.Models.StoredShipments;
using Xunit;
using Parcel = Unifaun.Rest.Client.Models.Price.Parcel;
using Receiver = Unifaun.Rest.Client.Models.Price.Receiver;
using Sender = Unifaun.Rest.Client.Models.Price.Sender;
using Service = Unifaun.Rest.Client.Models.Price.Service;

namespace Unifaun.Rest.Client.Tests
{
    public class PriceTest : UnifaunBaseTest
    {
        [Fact]
        public async Task GetPrice_Test()
        {
            var request = new PriceRequest
            {
                AdditionalSurcharges = new AdditionalSurcharges
                {
                    Percent = 5
                },
                Shipment = new Shipment
                {
                    SenderReference = "test",
                    ReceiverReference = "price",
                    GoodsDescription = "goods",
                    Sender = new Sender
                    {
                        QuickId = "1"
                    },
                    Receiver = new Receiver
                    {
                        Name = "Larry McGuver",
                        Address1 = "1234 Fair Road",
                        Zipcode = "91001",
                        City = "ALTADENA",

                        Country = "US",
                        Phone = "0703305551"

                    },
                    Service = new Service
                    {
                        Id = "DAWPX"
                    },
                    
                    Parcels = new []
                    {
                        new Parcel
                        {
                            Copies = 1,
                            Weight = 1,
                            Contents = "yes"
                        }
                    },
                    CustomsDeclaration = new CustomsDeclaration
                    {
                        
                    }
                }
            };

            var price = await this.Client.Prices(request);
        }
    }
}
