using ChaserFood.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChaserFood.Controllers
{
    public class InventoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InventoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var items = await _context.InventoryItems.ToListAsync();
            return View(items);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.InventoryItems.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            _context.InventoryItems.Remove(item);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
