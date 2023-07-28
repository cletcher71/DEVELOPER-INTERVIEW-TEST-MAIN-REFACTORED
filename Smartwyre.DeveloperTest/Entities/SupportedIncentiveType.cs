using System.ComponentModel.DataAnnotations;

namespace Smartwyre.DeveloperTest.Entities
{
    public class SupportedIncentiveType
    {
        public int Id { get; set; }

        public required string Identifier { get; set; }

        public string? Incentive { get; set; }

        public decimal Amount { get; set; }

        public decimal Percentage { get; set; }
    }
}