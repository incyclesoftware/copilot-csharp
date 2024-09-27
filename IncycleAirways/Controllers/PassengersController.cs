using IncycleAirways.Data;
using IncycleAirways.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IncycleAirways.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PassengersController : Controller
    {
        private IPassengersRepository passengersRepository;
        PassengersController(IPassengersRepository passengersRepository)
        {
            this.passengersRepository = passengersRepository;
        }

        [HttpGet("version")]
        public string GetVersion()
        {
            return "1.0.0";
        }

        [HttpGet("search/{partial}")]
        public List<PlanePassenger> SearchPassengers(string partial)
        {
            return passengersRepository.GetPassengers().Where(p => p.FirstName.Contains(partial)||p.LastName.Contains(partial)).ToList();
        }
    }
}
