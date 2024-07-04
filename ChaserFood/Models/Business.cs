using System.ComponentModel.DataAnnotations;

namespace ChaserFood.Models
{
    public class Business //donors
    {
        [Key] public int BusinessId { get; set; } // Primary Key
        public string PhoneNumber { get; set; }
        public string BusinessName { get; set; } // Not Null
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string? Title { get; set; }
        public string? EmailAddress { get; set; }
    }
}
