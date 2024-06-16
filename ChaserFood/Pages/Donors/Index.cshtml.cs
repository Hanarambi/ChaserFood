using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ChaserFood.Data;
using ChaserFood.Models;

namespace ChaserFood.Pages.Donors
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Donor> Donors { get; set; }

        public async Task OnGetAsync()
        {
            Donors = await _context.Donors.ToListAsync();
        }
    }
}
