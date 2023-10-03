using BetCarreiro.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BetCarreiro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BetController : ControllerBase
    {
        private readonly ILogger<BetController> _logger;

        public BetController(ILogger<BetController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetBets")]
        public IEnumerable<Bet> Get()
        {
            var bets = new List<Bet>
            {
                new Bet(Guid.NewGuid(), Guid.NewGuid(), "Bahia x Vitoria", 50.0, DateTime.Now),
                new Bet(Guid.NewGuid(), Guid.NewGuid(), "Real x Barça", 75.0, DateTime.Now),
                new Bet(Guid.NewGuid(), Guid.NewGuid(), "City x PSG", 100.0, DateTime.Now),
                new Bet(Guid.NewGuid(), Guid.NewGuid(), "Flamengo x Madureira", 25.0, DateTime.Now),
                new Bet(Guid.NewGuid(), Guid.NewGuid(), "Sport x SantaCruz", 150.0, DateTime.Now)
            };
            return bets;
        }
    }
}