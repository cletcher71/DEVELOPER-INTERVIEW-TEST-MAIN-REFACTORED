
using System;
using System.ComponentModel.DataAnnotations;

namespace Smartwyre.DeveloperTest.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public required String Identifier { get; set; }

        public decimal Price { get; set; }

        public String? Uom { get; set; }

    }
}