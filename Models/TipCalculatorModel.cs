namespace Calculator_Project.Models
{
    public class TipCalculatorModel
    {
        public decimal Bill { get; set; }
        public decimal CalculatePercent15() 
        {
            return Bill * 0.15m;
        }
        public decimal CalculatePercent20() 
        {
            return Bill * 0.10m;
        }
        public decimal CalculatePercent25() 
        {
            return Bill * 0.25m;
        }
    }
}