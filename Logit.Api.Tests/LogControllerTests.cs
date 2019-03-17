using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logit.Api.Tests
{
    [TestClass]
    public class LogControllerTests
    {
        [TestMethod]
        public async Task CanGetLogs()
        {
            var builder = new WebHostBuilder().UseStartup<Startup>();
            var server = new TestServer(builder);
            var client = server.CreateClient();

            var result = await client.GetAsync("api/log");
            Assert.IsTrue(result.IsSuccessStatusCode);

            string response = await result.Content.ReadAsStringAsync();

            
        }

        [TestMethod]
        public async Task CanGetLogsFiltered()
        {
            var builder = new WebHostBuilder().UseStartup<Startup>();
            var server = new TestServer(builder);
            var client = server.CreateClient();

            var query = new Dictionary<string, string>() { { "CreatedBy", "Eileen" } };
            var result = await client.GetAsync(QueryHelpers.AddQueryString("api/log/filter", query));
            string response = await result.Content.ReadAsStringAsync();

            Assert.IsTrue(result.IsSuccessStatusCode);
        }
    }
}
