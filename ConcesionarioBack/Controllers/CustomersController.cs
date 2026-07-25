using ConcesionarioBack.Entities;
using ConcesionarioBack.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConcesionarioBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private CustomersService service;
        public CustomersController(CustomersService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<Customer>>> GetCustomersAsync()
        {
            var customers = await service.GetCustomersAsync();
            return Ok(customers);
        }
    }
}
