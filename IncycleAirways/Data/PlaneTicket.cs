namespace IncycleAirways.Data
{
    public class PlaneTicket
    {
        public string TicketNumber { get; set; }
        public PlanePassenger Passenger { get; set; }
        public PlaneSeat Seat { get; set; }
        public string FlightNumber { get; set; }
    }
}
