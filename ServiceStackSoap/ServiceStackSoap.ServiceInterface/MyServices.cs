using System.Threading.Tasks;
using ServiceStack;
using ServiceStackSoap.ServiceModel;

namespace ServiceStackSoap.ServiceInterface
{
    public class MyServices : Service
    {
        public async Task<object> Any(Hello request)
        {
            var url = $"https://jsonplaceholder.typicode.com/users/{request.Id}";

            var response = await url.GetJsonFromUrlAsync().ConfigureAwait(false);

            return new HelloResponse { Result = response };
        }
    }
}