using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using ChaserFood.Data;
using ChaserFood.Models;
using ChaserFood.Services;
using Microsoft.AspNetCore.Mvc;

public class InventoryModel : PageModel
{
    private readonly ApplicationDbContext _context;
    private readonly InventoryService _inventoryService;

    public InventoryModel(ApplicationDbContext context, InventoryService inventoryService)
    {
        _context = context;
        _inventoryService = inventoryService;
    }

    public IList<InventoryItem> Items { get; set; }

    [BindProperty]
    public InventoryItem ScannedItem { get; set; }

    public async Task OnGetAsync()
    {
        Items = await _context.InventoryItems.ToListAsync();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        await _inventoryService.AddOrUpdateItemAsync(ScannedItem);
        return RedirectToPage();
    }
}
