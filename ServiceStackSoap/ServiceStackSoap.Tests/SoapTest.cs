using NUnit.Framework;
using ServiceStack;
using ServiceStackSoap.ServiceModel;

namespace ServiceStackSoap.Tests
{
    public class SoapTest
    {
        [Test]
        public void TestSoap12()
        {
            var client = new Soap12ServiceClient("http://localhost:6982/");
            
            var response = client.Send<HelloResponse>(new Hello { Id = 1 });

            Assert.That(response.Result, Contains.Substring("Leanne Graham"));
        }

        [Test]
        public void TestJson()
        {
            var client = new JsonServiceClient("http://localhost:6982/");
            
            var response = client.Send<HelloResponse>(new Hello { Id = 1 });

            Assert.That(response.Result, Contains.Substring("Leanne Graham"));
        }
    }
}
