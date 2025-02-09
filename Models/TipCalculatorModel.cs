using System.ComponentModel.DataAnnotations;

namespace Calculator_Project.Models
{
    public class TipCalculatorModel
    {
        [Required(ErrorMessage = "Please enter a bill amount.")]
        [Range(0.01, 1000000, ErrorMessage = "Please enter a valid bill amount.")]    
        public decimal? BillAmount { get; set; }

        public decimal? CalculatePercent15() 
        {
            decimal? tip = BillAmount * 0.15m;
            return tip;
        }
        public decimal? CalculatePercent20() 
        {
            decimal? tip = BillAmount * 0.20m;
            return tip;
        }
        public decimal? CalculatePercent25() 
        {
            decimal? tip = BillAmount * 0.25m;
            return tip;
        }
    }
}