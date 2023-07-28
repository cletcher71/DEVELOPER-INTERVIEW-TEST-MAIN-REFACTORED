using System.ComponentModel.DataAnnotations;

namespace Smartwyre.DeveloperTest.Models
{
    public class RebateModel
    {
        public string Identifier { get; set; }

        //public IncentiveType Incentive { get; set; }

        public decimal Amount { get; set; }

        public decimal Percentage { get; set; }
    }
}