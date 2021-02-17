using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace API1IntegrationTest
{
    public class TestesCalculaJuros
    {
        [Fact]
        public async Task TesteRetornoCalculoDeJuros()
        {
            var client = new TestClientProvider().Client;

            var response = await client.GetAsync("/api/calculajuros");

            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
