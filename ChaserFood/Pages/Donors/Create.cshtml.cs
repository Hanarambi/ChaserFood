using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ChaserFood.Data;
using ChaserFood.Models;
using System.Threading.Tasks;

namespace ChaserFood.Pages.Donors
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Donor Donor { get; set; }

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

            _context.Donors.Add(Donor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
