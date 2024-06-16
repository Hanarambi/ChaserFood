using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ChaserFood.Data;
using ChaserFood.Models;

namespace ChaserFood.Services
{
    public class InventoryService
    {
        private readonly ApplicationDbContext _context;

        public InventoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<InventoryItem> GetItemByBarcodeAsync(string barcode)
        {
            return await _context.InventoryItems.FirstOrDefaultAsync(i => i.Barcode == barcode);
        }

        public async Task AddOrUpdateItemAsync(InventoryItem item)
        {
            var existingItem = await _context.InventoryItems.FirstOrDefaultAsync(i => i.Barcode == item.Barcode);
            if (existingItem != null)
            {
                existingItem.Name = item.Name;
                existingItem.Category = item.Category;
                existingItem.Quantity = item.Quantity;
                existingItem.ExpirationDate = item.ExpirationDate;
                _context.Update(existingItem);
            }
            else
            {
                _context.Add(item);
            }
            await _context.SaveChangesAsync();
        }
    }
}
