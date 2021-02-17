using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace API2.IntegrationTests
{
    public class TestesShowMeTheCode
    {
        [Fact]
        public async Task TesteShowMeTheCode()
        {
            var client = new TestClientProvider().Client;

            var response = await client.GetAsync("/api/showmethecode");

            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
