using System.ComponentModel.DataAnnotations;

namespace ChaserFood.Data
{
    public class Brand
    {
        [Key] public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
