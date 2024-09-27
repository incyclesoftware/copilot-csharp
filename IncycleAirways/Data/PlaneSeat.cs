namespace IncycleAirways.Data
{
    public class PlaneSeat
    {
        public enum SeatType
        {
            Economy,
            PremiumEconomy,
            Business,
            FirstClass
        }
        public string SeatNumber { get; set; }
        public SeatType Type { get; set; }
    }
}
