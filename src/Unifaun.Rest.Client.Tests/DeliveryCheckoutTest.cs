using System.Threading.Tasks;
using Xunit;

namespace Unifaun.Rest.Client.Tests
{
    public class DeliveryCheckoutTest : UnifaunBaseTest
    {
        [Fact]
        public async Task DeliveryCheckout_Test()
        {
            var options = await this.Client.DeliveryCheckout("xxx", "SEK", "sv", "SE", "93134");
        }
    }
}
