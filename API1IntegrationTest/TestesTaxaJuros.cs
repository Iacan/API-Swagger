using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace API1IntegrationTest
{
    public class TestesTaxaJuros
    {
        [Fact]
        public async Task TesteRetornoTaxaJuros()
        {
            var client = new TestClientProvider().Client;

            var response = await client.GetAsync("/api/taxajuros");

            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
