using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace API2.IntegrationTests
{
    public class QuandoRequisitarShowMeTheCode
    {
        [Fact]
        public async Task E_Possivel_Consultar_URL_Do_Linkedin()
        {
            var client = new TestClientProvider().Client;

            var response = await client.GetAsync("/api/showmethecode");

            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
