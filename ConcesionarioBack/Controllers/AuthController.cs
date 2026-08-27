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
        private readonly IEmployeesService _service;
        public AuthController(IEmployeesService service)
        {
            _service = service;
        }
        [HttpGet("login")]
        public async Task<ActionResult<Employe>> Login([FromQuery] AuthLoginDto login)
        {
            var employe = await this._service.GetLogin(login);
            if (employe == null)
            {
                return NotFound("Empleado no encontrado");
            }
            else
            {
                return Ok(employe);
            }
        }
    }
}
