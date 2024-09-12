using System.ComponentModel.DataAnnotations;

namespace ChaserFood.Models
{
    public class Category
    {
        [Key] public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
