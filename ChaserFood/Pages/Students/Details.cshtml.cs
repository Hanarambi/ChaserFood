using System.Threading.Tasks;
using ChaserFood.Data;
using ChaserFood.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChaserFood.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public NewClientModel Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Student = await _context.NewClients.FindAsync(id);

            if (Student == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
