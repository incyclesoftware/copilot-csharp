using IncycleAirways.Data;
using IncycleAirways.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IncycleAirways.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightsController : Controller
    {
        private readonly IFlightsRepository flightsRepository;
        public FlightsController(IFlightsRepository flightsRepository)
        {
            this.flightsRepository = flightsRepository ?? throw new ArgumentNullException(nameof(flightsRepository));
        }
        [HttpGet("version")]
        public string GetVersion()
        {
            return "1.0.0";
        }

        [HttpGet("view/{from}/{to}")]
        public List<Flight> GetFlights(string from, string to)
        {
            return flightsRepository.GetFlights().Where(f => f.Origin == from && f.Destination == to).ToList();
        }

        [HttpGet("random_flight")]
        public Flight? GetRandomFlight()
        {
            return flightsRepository.GetFlights().FirstOrDefault();
        }

        [HttpGet("from/{origin}")]
        public List<Flight> GetFrom(string origin)
        {
            return flightsRepository.GetFlights().Where(f => f.Origin == origin).ToList();
        }
    }
}
