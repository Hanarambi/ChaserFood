using System.ComponentModel.DataAnnotations;

namespace ChaserFood.Models
{
    public class Location
    {
        [Key] public int LocationId { get; set; }
        public string LocationName { get; set; }
    }
}
