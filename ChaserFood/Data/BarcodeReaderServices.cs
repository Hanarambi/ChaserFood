using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace ChaserFood.Data
{
    public class BarcodeReaderService
    {
        private readonly HttpClient _httpClient;
        private readonly ApplicationDbContext _context;

        public BarcodeReaderService(HttpClient httpClient, ApplicationDbContext context)
        {
            _httpClient = httpClient;
            _context = context;
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
                var productDetails = JObject.Parse(responseBody);

                // Check the database for the product details
                var barcode = productDetails["barcode"].ToString();
                var item = await _context.InventoryItems.FirstOrDefaultAsync(i => i.Barcode == barcode);

                if (item != null)
                {
                    // If the item is found in the database, return its details
                    return JObject.FromObject(item);
                }
                else
                {
                    // If the item is not found in the database, return a new JObject with blank fields
                    return new JObject
                    {
                        ["Name"] = "",
                        ["Category"] = "",
                        ["Quantity"] = 0,
                        ["ExpirationDate"] = null,
                        ["Barcode"] = barcode
                    };
                }
            }
        }
    }
}
