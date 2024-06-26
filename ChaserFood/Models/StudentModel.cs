using System.ComponentModel.DataAnnotations;

namespace ChaserFood.Models
{
    public class StudentModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string SchoolID { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [MaxLength(100)]
        public string StreetAddress { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [MaxLength(2)]
        public string State { get; set; }

        [Required]
        [MaxLength(10)]
        public string ZipCode { get; set; }

        [Required]
        [MaxLength(50)]
        public string County { get; set; }

        [Required]
        public int CurrentAge { get; set; }

        [Required]
        [MaxLength(10)]
        public string Gender { get; set; }

        [Required]
        [MaxLength(50)]
        public string Race { get; set; }

        [Required]
        [MaxLength(50)]
        public string EmploymentStatus { get; set; }

        [Required]
        [MaxLength(50)]
        public string StudentStatus { get; set; }

        [Required]
        public int NumberOfFamilyMembers { get; set; }

        [Required]
        public int NumberOfAdults { get; set; }

        [Required]
        public int NumberOfChildren { get; set; }

        [Required]
        [MaxLength(100)]
        public string AgesOfChildren { get; set; }

        [Required]
        public bool AnyElderly { get; set; }

        [Required]
        public int NumberOfEmployedFamilyMembers { get; set; }

        [Required]
        [MaxLength(50)]
        public string HousingStatus { get; set; }

        [Required]
        public bool HasTransportation { get; set; }

        [Required]
        public bool HasStove { get; set; }

        [Required]
        public bool HasMicrowave { get; set; }

        [Required]
        public bool HasCanOpener { get; set; }

        [Required]
        public bool HasRunningWater { get; set; }

        [Required]
        [MaxLength(100)]
        public string DietaryRestrictions { get; set; }

        [Required]
        [MaxLength(100)]
        public string FoodAllergies { get; set; }

        [Required]
        [MaxLength(100)]
        public string TypesOfFoodConsumed { get; set; }
    }
}
