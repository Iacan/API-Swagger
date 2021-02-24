using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ShowMeTheCode.IntegrationTests
{
    public class TestClientProvider
    {
        public HttpClient Client { get; private set; }

        public TestClientProvider()
        {
            //var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());

            //Client = server.CreateClient();
        }
    }
}
