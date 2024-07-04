// Models/ProductRequest.cs
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChaserFood.Models
{
    public class ProductRequest
    {
        public int Id { get; set; }

        [Required]
        public string SchoolID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public string PreferredMethodOfContact { get; set; }

        public string PreferredPickUpLocation { get; set; }

        public DateTime DateOfRequest { get; set; }

        public TimeSpan TimeOfRequest { get; set; }

        public List<ProductSelection> ProductSelections { get; set; }
    }

    public class ProductSelection
    {
        public int Id { get; set; }

        public int ProductRequestId { get; set; }

        public string ProductID { get; set; }

        public string Category { get; set; }

        public string ProductType { get; set; }

        public string NameBrand { get; set; }

        public string ProductDetails { get; set; }

        public string QtyPackageType { get; set; }

        public int Qty { get; set; }
    }
}
