using System.ComponentModel.DataAnnotations;

namespace ChaserFood.Data
{
    public class Location
    {
        [Key] public int LocationId { get; set; }
        public string LocationName { get; set; }
    }
}
