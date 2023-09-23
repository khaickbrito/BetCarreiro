using Microsoft.AspNetCore.Mvc;

namespace BetCarreiro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCustomers")]
        public IEnumerable<Customer> Get()
        {
            return Enumerable.Range(1, 5).Select(index => 
                new Customer("Pedro", 200))
                .ToArray();
        }
    }
}