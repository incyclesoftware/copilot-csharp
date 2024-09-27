using IncycleAirways.Data;

namespace IncycleAirways.Repositories
{
    public interface IPassengersRepository
    {
        bool AddPassenger(PlanePassenger passenger);
        bool RemovePassenger(PlanePassenger passenger);
        List<PlanePassenger> GetPassengers();
        List<PlanePassenger> GetPassengersByFlight(string flightNumber);
        List<PlanePassenger> GetPassengersName(string name);
    }
}
