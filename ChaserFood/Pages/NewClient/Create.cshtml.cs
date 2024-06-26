using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ChaserFood.Data;
using ChaserFood.Models;

namespace ChaserFood.Pages.NewClient
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public NewClientModel NewClient { get; set; }

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.NewClients.Add(NewClient);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
