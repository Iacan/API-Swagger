using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace API1IntegrationTest
{
    public class QuandoRequisitarCalculoDeJuros
    {
        [Fact]
        public async Task E_Possivel_Efetuar_Calculo_De_Juros()
        {
            var client = new TestClientProvider().Client;

            var response = await client.GetAsync("/api/calculajuros");

            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
