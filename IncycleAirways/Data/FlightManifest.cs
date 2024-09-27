namespace IncycleAirways.Data
{
    public class FlightManifest
    {
        public  string FlightNumber { get; set; }
        public DateTime DepartureDate { get; set; }
        public List<PlaneTicket> Ticket { get; set; }
    }
}
