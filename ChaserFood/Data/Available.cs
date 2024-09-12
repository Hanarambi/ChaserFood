using System.ComponentModel.DataAnnotations;

namespace ChaserFood.Data
{
    public class Available
    {
        [Key] public string Barcode { get; set; }
        public string Location_id { get; set; }
        public int Count { get; set; }
        public string Notes { get; set; }
    }
}
