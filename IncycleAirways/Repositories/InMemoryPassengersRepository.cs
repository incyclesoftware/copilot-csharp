using IncycleAirways.Data;

namespace IncycleAirways.Repositories
{
    public class InMemoryPassengersRepository : IPassengersRepository
    {
        List<PlanePassenger> passengers = new List<PlanePassenger>();
        public InMemoryPassengersRepository() {
            // load mock data from csv file

        }
        public bool AddPassenger(PlanePassenger passenger)
        {
            passengers.Add(passenger);
            return true;
        }

        public List<PlanePassenger> GetPassengers()
        {
            throw new NotImplementedException();
        }

        public List<PlanePassenger> GetPassengersByFlight(string flightNumber)
        {
            throw new NotImplementedException();
        }

        public List<PlanePassenger> GetPassengersName(string name)
        {
            throw new NotImplementedException();
        }

        public bool RemovePassenger(PlanePassenger passenger)
        {
            throw new NotImplementedException();
        }
    }
}
