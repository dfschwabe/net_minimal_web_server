using System.Net;
using System.Net.Http;
using NUnit.Framework;
using OnDemandWebServer;

namespace OnDemandWebServerTests
{
    [TestFixture]
    public class MyServerTests
    {
        private MyServer _server;
        private const string BaseUrl = "http://localhost:9000";

        [SetUp]
        public void Setup()
        {
            _server = new MyServer();
            _server.Start(BaseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            _server.Stop();
        }

        [Test]
        public void DoIt()
        {
            var response = new HttpClient().GetAsync($"{BaseUrl}/api/testing").Result;

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
