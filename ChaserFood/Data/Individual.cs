using System.ComponentModel.DataAnnotations;

namespace ChaserFood.Data
{
    public class Individual
    {
        [Key] public int IndividualId { get; set; }
        public string PhoneNumber { get; set; } // Primary Key
        public string FirstName { get; set; } // Not Null
        public string LastName { get; set; } // Not Null
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string? EmailAddress { get; set; }
        public bool? WithSchool { get; set; } // null-not with school, false-student, true-staff/faculty
    }
}
