using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChaserFood.Data;
using ChaserFood.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

public class StudentsModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public StudentsModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<NewClientModel> Students { get; set; }

    [BindProperty(SupportsGet = true)]
    public string SearchString { get; set; }

    [BindProperty(SupportsGet = true)]
    public string SearchBy { get; set; }

    public async Task OnGetAsync()
    {
        IQueryable<NewClientModel> studentsQuery = from s in _context.NewClients
                                                   select s;

        if (!string.IsNullOrEmpty(SearchString))
        {
            if (SearchBy == "SchoolID")
            {
                studentsQuery = studentsQuery.Where(s => s.SchoolID.Contains(SearchString));
            }
            else if (SearchBy == "LastName")
            {
                studentsQuery = studentsQuery.Where(s => s.LastName.Contains(SearchString));
            }
        }

        Students = await studentsQuery.ToListAsync();
    }
}
