using System.ComponentModel.DataAnnotations;

namespace ChaserFood.Models
{
    public class Purchased
    {
        [Key] public DateTime Date { get; set; } // Primary Key
        public string Purchaser { get; set; }
        public long? PhoneNumber { get; set; } // not sure we need this tbh
    }
}
