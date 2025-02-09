namespace Calculator_Project.Models
{
    public class TipCalculatorModel
    {
        public decimal BillAmount { get; set; }
        public decimal CalculatePercent15() 
        {
            return BillAmount * 0.15m;
        }
        public decimal CalculatePercent20() 
        {
            return BillAmount * 0.10m;
        }
        public decimal CalculatePercent25() 
        {
            return BillAmount * 0.25m;
        }
    }
}