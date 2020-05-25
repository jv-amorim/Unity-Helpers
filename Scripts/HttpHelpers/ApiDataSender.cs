using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UnityHelpers.HttpHelpers
{
    /// <summary>
    /// Common methods for sending data to an API.
    /// </summary>
    public static class ApiDataSender
    {
        /// <summary>
        /// Sends raw JSON data to the API located at the URI 
        /// passed as a parameter. Uses POST method.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public async static Task<bool> SendJSONData(string uri, string json)
        {
            try
            {
                HttpClient client = new HttpClient();
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(uri, content);
                response.EnsureSuccessStatusCode();

                return true;
            }
            catch (HttpRequestException error)
            {
                return false;
            }
        }
    }
}