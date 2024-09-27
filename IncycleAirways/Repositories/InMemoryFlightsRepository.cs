using IncycleAirways.Data;

namespace IncycleAirways.Repositories
{
    public class InMemoryFlightsRepository : IFlightsRepository
    {
        public InMemoryFlightsRepository()
        {
            var flightsFile = File.OpenRead("MockData/flights.csv");
            var reader = new StreamReader(flightsFile);
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line?.Split(',');
                if (values == null) continue;
                var flight = new Flight
                {
                    FlightNumber = values[0],
                    Origin = values[1],
                    Destination = values[2],
                    DepartureTime = values[3],
                    ArrivalTime = values[4],
                    Capacity = int.Parse(values[5])
                };
                flights.Add(flight.FlightNumber, flight);
            }

        }

        Dictionary<string, Flight> flights = new();
        public bool AddFlight(Flight flight)
        {
            if (flights.ContainsKey(flight.FlightNumber))
            {
                return false;
            }
            flights.Add(flight.FlightNumber, flight);
            return true;
        }

        public bool RemoveFlight(Flight flight)
        {
            if (flights.ContainsKey(flight.FlightNumber))
            {
                flights.Remove(flight.FlightNumber);
                return true;
            }
            return false;
        }

        public List<Flight> GetFlights()
        {
            return flights.Values.ToList();
        }
    }
}
