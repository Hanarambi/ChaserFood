using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ChaserFood.Data
{
    public class BarcodeReaderService
    {
        private readonly HttpClient _httpClient;

        public BarcodeReaderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("x-rapidapi-host", "product-lookup-by-upc-or-ean1.p.rapidapi.com");
            _httpClient.DefaultRequestHeaders.Add("x-rapidapi-key", "51354b1446msh12625f93c4f676fp132e00jsn209e7e826149");
        }

        public async Task<JObject> GetProductDetails(string filePath)
        {
            var imageBytes = await File.ReadAllBytesAsync(filePath);
            using (var content = new ByteArrayContent(imageBytes))
            {
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                var response = await _httpClient.PostAsync("https://product-lookup-by-upc-or-ean1.p.rapidapi.com/?upc=", content);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                return JObject.Parse(responseBody);
            }
        }
    }
}
