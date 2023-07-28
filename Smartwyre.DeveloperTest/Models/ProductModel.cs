using System.ComponentModel.DataAnnotations;

namespace Smartwyre.DeveloperTest.Models
{
    public class ProductModel
    {
        public required String Identifier { get; set; }

        public decimal Price { get; set; }

        public String? Uom { get; set; }

    }
}