using IncycleAirways.Data;

namespace IncycleAirways.Repositories
{
    public class InMemoryTicketsRepository
    {
        List<PlaneTicket> tickets = new List<PlaneTicket>();
        public bool AddTicket(PlaneTicket ticket)
        {
            tickets.Add(ticket);
            return true;
        }

        public bool RemoveTicket(PlaneTicket ticket)
        {
            tickets.Remove(ticket);
            return true;
        }

        public List<PlaneTicket> GetTicketsForFlight(string flightNumber)
        {
            return tickets.Where(t => t.FlightNumber == flightNumber).ToList();
        }
    }
}
