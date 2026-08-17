using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;
using ConcesionarioBack.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConcesionarioBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ICustomersService _service;
        public AuthController(ICustomersService service)
        {
            _service = service;
        }
        [HttpGet("login")]
        public async Task<ActionResult<Customer>> Login([FromQuery] AuthLoginDto login)
        {
            var customer = await this._service.GetLogin(login);
            if (customer == null)
            {
                return NotFound("Usuario no encontrado");
            }
            else
            {
                return Ok(customer);
            }
        }
    }
}
