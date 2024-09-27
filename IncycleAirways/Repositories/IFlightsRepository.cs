using IncycleAirways.Data;

namespace IncycleAirways.Repositories
{
    public interface IFlightsRepository
    {
        bool AddFlight(Flight flight);
        bool RemoveFlight(Flight flight);
        List<Flight> GetFlights();

    }
}
