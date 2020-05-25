using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace UnityHelpers.HttpHelpers
{
    /// <summary>
    /// Common methods for requesting API data.
    /// </summary>
    public static class ApiDataRequester
    {
        /// <summary>
        /// Returns raw JSON data from the API located at the URI 
        /// passed as a parameter. Uses GET method.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static async Task<string> RequestJSONData(string uri)
        {
            try
            {
                HttpClient client = new HttpClient();
                string responseBody = await client.GetStringAsync(uri);
                return responseBody;
            }
            catch (HttpRequestException error)
            {
                return null;
            }
        }

        public static void DownloadFile(string imageFullUri, string folderNameToSave, string fileNameToSave)
        {
            Directory.CreateDirectory(folderNameToSave);

            try
            {
                Uri uri = new Uri(imageFullUri);
                WebClient webClient = new WebClient();
                webClient.DownloadFile(uri, folderNameToSave + fileNameToSave);
            }
            catch (WebException error) { }
        }

        public static void DownloadFileAsync(string imageFullUri, string folderNameToSave, string fileNameToSave)
        {
            Directory.CreateDirectory(folderNameToSave);

            Uri uri = new Uri(imageFullUri);
            WebClient webClient = new WebClient();
            webClient.DownloadFileAsync(uri, folderNameToSave + fileNameToSave);
        }
    }
}