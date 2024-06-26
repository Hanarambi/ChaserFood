using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ChaserFood.Data;
using ChaserFood.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChaserFood.Pages.NewClient
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<NewClientModel> NewClients { get; set; }

        public async Task OnGetAsync()
        {
            NewClients = await _context.NewClients.ToListAsync();
        }
    }
}
