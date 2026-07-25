using ConcesionarioBack.Entities;
using ConcesionarioBack.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConcesionarioBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private VehiclesService service;
        public VehiclesController(VehiclesService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<Vehicle>>> GetVehiclesAsync()
        {
            var vehicles = await service.GetVehiclesAsync();
            return Ok(vehicles);
        }
    }
}
