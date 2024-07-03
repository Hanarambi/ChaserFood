using System.ComponentModel.DataAnnotations;

namespace ChaserFood.Models
{
    public class Brand
    {
        [Key] public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
