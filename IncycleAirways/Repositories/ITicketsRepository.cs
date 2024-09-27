using IncycleAirways.Data;

namespace IncycleAirways.Repositories
{
    public interface ITicketsRepository
    {
        bool AddTicket(PlaneTicket ticket);
        bool RemoveTicket(PlaneTicket ticket);
        bool CancelTicket(string ticketNumber);
        bool UseTicket(string ticketNumber);
        List<PlaneTicket> GetTicketsForFlight(string flightNumber);
    }
}
