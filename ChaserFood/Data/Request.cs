using System.ComponentModel.DataAnnotations;

namespace ChaserFood.Data
{
    public class Request
    {
        [Key] public int RequestNumber { get; set; } // Primary Key
        public int StudentId { get; set; } // Foreign Key
        public string Barcode { get; set; } // Not Null
        public int RequestCount { get; set; }
    }
}
