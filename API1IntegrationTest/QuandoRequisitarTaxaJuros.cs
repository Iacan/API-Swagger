using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace API1IntegrationTest
{
    public class QuandoRequisitarTaxaJuros
    {
        [Fact]
        public async Task E_Possivel_Consultar_Taxa_Juros()
        {
            var client = new TestClientProvider().Client;

            var response = await client.GetAsync("/api/taxajuros");

            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
