using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace ChaserFood.Data
{
    public class Client
    {
        [Key] public int StudentId { get; set; } // Primary Key
        public string LastName { get; set; } // Primary Key
        public string FirstName { get; set; } // Not Null
        public long PhoneNumber { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string? EmailAddress { get; set; }
        public int HouseholdAdults { get; set; }
        public int HouseholdChildren { get; set; } // Under 18
        public bool HasStove { get; set; }
        public bool HasMicrowave { get; set; }
        public bool HasCanOpener { get; set; }
        public bool HasRunningWater { get; set; }
        public string? DietaryRestrictions { get; set; } // MediumText
        public string? Allergies { get; set; } // MediumText
        public int Age { get; set; } // Not Null

        // Ethnicity
        public bool AfricanAmerican { get; set; }
        public bool Asian { get; set; }
        public bool Caucasian { get; set; }
        public bool Latino { get; set; }
        public bool MiddleEastern { get; set; }
        public bool NativeAmerican { get; set; }
        public bool PacificIslander { get; set; }
        public bool Other { get; set; }
        public string? OtherWriteIn { get; set; }

        public string Gender { get; set; } // Limit options?

        public bool HasTransportation { get; set; }
        public bool IsStaff { get; set; }
        public bool IsFaculty { get; set; }

        // Student Status
        public bool FullTimeStudent { get; set; }
        public bool PartTimeStudent { get; set; }
        public bool TraditionalStudent { get; set; }
        public bool NonTraditionalStudent { get; set; }

        public bool IsEmployed { get; set; }
        public string EmploymentStatus { get; set; } // Full-time or part time

        public int HouseholdEmployed { get; set; } // Number of people in household who are employed
        public string Housing { get; set; } // On-campus, off-campus, other??
        public string? BenefitsReceived { get; set; } // WIC, SNAP, TANF

        public bool LearnAboutBenefits { get; set; }
        public string? LearnWhichBenefits { get; set; }
    }

}
