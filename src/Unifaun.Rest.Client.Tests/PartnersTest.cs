using System.Threading.Tasks;
using Unifaun.Rest.Client.Models.Meta;
using Xunit;

namespace Unifaun.Rest.Client.Tests
{
    public class PartnersTest : UnifaunBaseTest
    {

        [Fact]
        public void DeserializeJsonToString_Test()
        {
            var jsonString = @"[{
    ""id"": ""PLAB"",
    ""description"": ""PostNord Sverige AB"",
    ""services"": [{
      ""id"": ""P53"",
      ""subId"": null,
      ""description"": ""PostNord Pallet Special"",
      ""uniqueDescription"": ""PostNord Pallet Special"",
      ""printSet"": [
                ""LABEL"",
                ""SIS"",
                ""DNGDECL""
              ],
      ""addons"": [{
        ""id"": ""NDLV"",
        ""description"": ""Ny utkörning"",
        ""routes"": null,
        ""values"":null
      }],
      ""options"": [{
        ""id"": ""ENOT"",
        ""description"": ""Föravisering (E-post)"",
        ""routes"": null,
        ""values"": null
      }, {
        ""id"": ""LNKPRTN"",
        ""description"": ""Länk till utskrift (tur)"",
        ""routes"": null,
        ""values"": null
      }],
      ""packageCodes"": [{
        ""id"": ""PC"",
        ""description"": ""Paket (PC)""
      }, {
        ""id"": ""CW"",
        ""description"": ""Bur (CW)""
      }, {
        ""id"": ""PE"",
        ""description"": ""Pall EUR (PE)""
      }, {
        ""id"": ""AF"",
        ""description"": ""Halvpall EUR (AF)""
      }, {
        ""id"": ""OA"",
        ""description"": ""Kvartspall (OA)""
      }, {
        ""id"": ""OF"",
        ""description"": ""Specialpall (OF)""
      }],
      ""routes"": [{
        ""from"": [""SE""],
        ""to"": [""SE""]
      }],
      ""sender"": {
        ""valid"": true,
        ""description"": ""Avsändare""
      },
      ""dispatch"": {
        ""valid"": false,
        ""description"": ""Upphämtningsadress""
      },
      ""receiver"": {
        ""valid"": true,
        ""description"": ""Mottagare""
      },
      ""delivery"": {
        ""valid"": false,
        ""description"": ""Leveransadress""
      },
      ""returnPart"": {
        ""valid"": false,
        ""description"": ""Returadress""
      },
      ""freightPayer"": {
        ""valid"": false,
        ""description"": ""Betalare, frakt""
      },
      ""taxPayer"": {
        ""valid"": false,
        ""description"": ""Betalare, skatt""
      },
      ""customsPayer"": {
       ""valid"": false,
        ""description"": ""Tullbetalare""
      }
    }]
  }]";
            var response = UnifaunRestClient.DeserializeJson<Partner[]>(jsonString);

            Assert.Equal("PLAB", response[0].Id);
            Assert.Equal("P53", response[0].Services[0].Id);
            Assert.False(response[0].Services[0].FreightPayer.Valid);
            Assert.True(response[0].Services[0].Sender.Valid);
        }

        [Fact]
        public async Task Partners_Test()
        {
            var partners = await this.Client.Partners("sv");

            Assert.True(partners.Length > 0);
        }

        [Fact]
        public async Task Partners_JsonString_Test()
        {
            var partners = await this.Client.PartnersJson("sv");

            Assert.False(string.IsNullOrEmpty(partners));
        }
    }
}
