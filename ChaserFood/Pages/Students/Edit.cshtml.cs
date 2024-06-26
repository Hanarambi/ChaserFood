using ChaserFood.Data;
using ChaserFood.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ChaserFood.Pages.Students
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public NewClientModel NewClient { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            NewClient = await _context.NewClients.FindAsync(id);

            if (NewClient == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var clientToUpdate = await _context.NewClients.FindAsync(id);

            if (clientToUpdate == null)
            {
                return NotFound();
            }

            // Update the properties of the client
            clientToUpdate.SchoolID = NewClient.SchoolID;
            clientToUpdate.FirstName = NewClient.FirstName;
            clientToUpdate.LastName = NewClient.LastName;
            clientToUpdate.PhoneNumber = NewClient.PhoneNumber;
            clientToUpdate.EmailAddress = NewClient.EmailAddress;
            clientToUpdate.StreetAddress = NewClient.StreetAddress;
            clientToUpdate.City = NewClient.City;
            clientToUpdate.State = NewClient.State;
            clientToUpdate.ZipCode = NewClient.ZipCode;
            clientToUpdate.County = NewClient.County;
            clientToUpdate.CurrentAge = NewClient.CurrentAge;
            clientToUpdate.Gender = NewClient.Gender;
            clientToUpdate.Race = NewClient.Race;
            clientToUpdate.EmploymentStatus = NewClient.EmploymentStatus;
            clientToUpdate.StudentStatus = NewClient.StudentStatus;
            clientToUpdate.NumberOfFamilyMembers = NewClient.NumberOfFamilyMembers;
            clientToUpdate.NumberOfAdults = NewClient.NumberOfAdults;
            clientToUpdate.NumberOfChildren = NewClient.NumberOfChildren;
            clientToUpdate.AgesOfChildren = NewClient.AgesOfChildren;
            clientToUpdate.AnyElderly = NewClient.AnyElderly;
            clientToUpdate.NumberOfEmployedFamilyMembers = NewClient.NumberOfEmployedFamilyMembers;
            clientToUpdate.HousingStatus = NewClient.HousingStatus;
            clientToUpdate.HasTransportation = NewClient.HasTransportation;
            clientToUpdate.HasStove = NewClient.HasStove;
            clientToUpdate.HasMicrowave = NewClient.HasMicrowave;
            clientToUpdate.HasCanOpener = NewClient.HasCanOpener;
            clientToUpdate.HasRunningWater = NewClient.HasRunningWater;
            clientToUpdate.DietaryRestrictions = NewClient.DietaryRestrictions;
            clientToUpdate.FoodAllergies = NewClient.FoodAllergies;
            clientToUpdate.TypesOfFoodConsumed = NewClient.TypesOfFoodConsumed;

            _context.Attach(clientToUpdate).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return RedirectToPage("/Students");
        }
    }
}
