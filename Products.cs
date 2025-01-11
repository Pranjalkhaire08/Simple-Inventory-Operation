using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using ProductCRUD.Models;

namespace InventoryManagement.Models
{
    [ModelMetadataType(typeof(ProductMetaData))]
   public class Products
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public string Color { get; set; }
            public decimal UnitPrice { get; set; }
            public int AvailablQuantity { get; set; }

            public DateTime CreatedDate { get; set; }
            public object AvailableQuantity { get; internal set; }
        }
    public class ProductsMetaData
    {

        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }

        [Required]
        [Display(Name = "Unit price")]
        public decimal UnitPrice { get; set; }

        [Required]
        [Display(Name = "Available quantity")]
        public int AvailableQuantity { get; set; }
    }
}
