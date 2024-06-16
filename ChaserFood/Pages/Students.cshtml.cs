using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using ChaserFood.Data;

public class StudentsModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public StudentsModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<Student> Students { get; set; }

    public async Task OnGetAsync()
    {
        Students = await _context.Students.ToListAsync();
    }
}
