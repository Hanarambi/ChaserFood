using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ChaserFood.Data;
using ChaserFood.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace ChaserFood.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarcodeController : ControllerBase
    {
        private readonly BarcodeReaderService _barcodeReaderService;
        private readonly ApplicationDbContext _context;

        public BarcodeController(BarcodeReaderService barcodeReaderService, ApplicationDbContext context)
        {
            _barcodeReaderService = barcodeReaderService;
            _context = context;
        }

        [HttpPost("read")]
        public async Task<IActionResult> ReadBarcode([FromBody] BarcodeImageModel model)
        {
            if (model == null || string.IsNullOrEmpty(model.ImageData))
            {
                return BadRequest(new { success = false, message = "Invalid data" });
            }

            try
            {
                // Decode the base64 image data
                var base64Data = model.ImageData.Split(',')[1];
                var imageBytes = Convert.FromBase64String(base64Data);

                // Save the image to a temporary file
                var tempFileName = Path.GetTempFileName();
                await System.IO.File.WriteAllBytesAsync(tempFileName, imageBytes);

                // Read the barcode using your barcode reader API
                var productDetails = await _barcodeReaderService.GetProductDetails(tempFileName);
                if (productDetails != null)
                {
                    var barcode = productDetails["barcode"]?.ToString();

                    // Store product details in the database
                    var inventoryItem = new InventoryItem
                    {
                        Barcode = barcode,
                        Name = productDetails["name"]?.ToString(),
                        Category = productDetails["category"]?.ToString(),
                        Quantity = 1, // Default quantity
                        ExpirationDate = DateTime.Now.AddYears(1) // Default expiration date
                    };
                    _context.InventoryItems.Add(inventoryItem);
                    await _context.SaveChangesAsync();

                    return Ok(new { success = true, barcode = barcode });
                }
                return BadRequest(new { success = false, message = "Could not read barcode" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }

        [HttpGet("details/{barcode}")]
        public async Task<IActionResult> GetDetails(string barcode)
        {
            var item = await _context.InventoryItems.FirstOrDefaultAsync(i => i.Barcode == barcode);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(new { name = item.Name, category = item.Category, quantity = item.Quantity, expirationDate = item.ExpirationDate });
        }
    }

    public class BarcodeImageModel
    {
        public string ImageData { get; set; }
    }
}
