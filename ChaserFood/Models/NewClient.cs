using System.ComponentModel.DataAnnotations;

namespace ChaserFood.Models
{
    public class NewClientModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SchoolID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        [Required]
        public string City { get; set; }

        [Required, StringLength(2)]
        public string State { get; set; }

        [Required]
        public string ZipCode { get; set; }

        [Required]
        public string County { get; set; }

        [Required]
        public int CurrentAge { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Race { get; set; }

        [Required]
        public string EmploymentStatus { get; set; }

        [Required]
        public string StudentStatus { get; set; }

        [Required]
        public int NumberOfFamilyMembers { get; set; }

        [Required]
        public int NumberOfAdults { get; set; }

        [Required]
        public int NumberOfChildren { get; set; }

        public string AgesOfChildren { get; set; }

        [Required]
        public bool AnyElderly { get; set; }

        [Required]
        public int NumberOfEmployedFamilyMembers { get; set; }

        [Required]
        public string HousingStatus { get; set; }

        public bool HasTransportation { get; set; }

        public bool HasStove { get; set; }

        public bool HasMicrowave { get; set; }

        public bool HasCanOpener { get; set; }

        public bool HasRunningWater { get; set; }

        public string DietaryRestrictions { get; set; }

        public string FoodAllergies { get; set; }

        public string TypesOfFoodConsumed { get; set; }
    }
}
