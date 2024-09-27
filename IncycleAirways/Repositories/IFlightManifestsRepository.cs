using IncycleAirways.Data;

namespace IncycleAirways.Repositories
{
    public interface IFlightManifestsRepository
    {
        bool AddManifest(FlightManifest manifest);
        bool RemoveManifest(FlightManifest manifest);
        List<FlightManifest> GetManifestsForFlight(string flightNumber);
    }
}
