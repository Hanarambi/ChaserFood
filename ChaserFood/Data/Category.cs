using System.ComponentModel.DataAnnotations;

namespace ChaserFood.Data
{
    public class Category
    {
        [Key] public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
