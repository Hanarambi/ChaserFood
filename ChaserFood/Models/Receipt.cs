using System.ComponentModel.DataAnnotations;

namespace ChaserFood.Models
{
    public class Receipt
    {
        [Key] public int DonationNumber { get; set; } // Primary Key
        public string PhoneNumber { get; set; } // Foreign Key
        public string Barcode { get; set; }
        public int DonatedCount { get; set; }
        public string LocationId { get; set; }
        public DateTime DonationDate { get; set; }
    }
}
