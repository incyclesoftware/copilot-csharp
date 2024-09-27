using IncycleAirways.Data;

namespace IncycleAirways.Repositories
{
    public class InMemoryFlightManifestRepository : IFlightManifestsRepository
    {
        List<FlightManifest> manifests = new List<FlightManifest>();

        bool IFlightManifestsRepository.AddManifest(FlightManifest manifest)
        {
            manifests.Add(manifest);
            return true;
        }

        List<FlightManifest> IFlightManifestsRepository.GetManifestsForFlight(string flightNumber)
        {
            return manifests.Where(m => m.FlightNumber == flightNumber).ToList();
        }

        bool IFlightManifestsRepository.RemoveManifest(FlightManifest manifest)
        {
            manifests.Remove(manifest);
            return true;
        }
    }
}
