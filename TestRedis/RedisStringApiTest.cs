
using System.Configuration;
using System.Net.Http.Headers;

namespace TestRedis
{
    public class RedisStringApiTest
    {
        private HttpClient client;
        private HttpResponseMessage response;


        [SetUp]
        public void Setup()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ApiUrl"]);
            response = client.GetAsync("contacts/get").Result;

        }

        [Test]
        public void Test1()
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            Assert.AreEqual("application/json", response.Content.Headers.ContentType.MediaType);
        }
    }
}