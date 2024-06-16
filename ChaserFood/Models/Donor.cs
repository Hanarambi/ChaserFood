using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChaserFood.Models
{
    [Table("individuals", Schema = "donor")]
    public class Donor
    {
        [Key]
        [Column("phone_number")]
        [StringLength(15)]
        public string PhoneNumber { get; set; }

        [Required]
        [Column("first_name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Column("last_name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Column("street_address")]
        [StringLength(100)]
        public string StreetAddress { get; set; }

        [Column("city")]
        [StringLength(50)]
        public string City { get; set; }

        [Column("state")]
        [StringLength(2)]
        public string State { get; set; }

        [Column("zip")]
        [StringLength(10)]
        public string Zip { get; set; }

        [Column("email_address")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [Column("with_school")]
        public bool WithSchool { get; set; }
    }
}
