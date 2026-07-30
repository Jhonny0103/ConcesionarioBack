using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;
using ConcesionarioBack.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
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

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<Vehicle>> GetVehicleByIdAsync(int id)
        {
            try
            {
                var vehicle = await service.GetVehicleByIdAsync(id);
                return Ok(vehicle);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<Vehicle>> CreateVehicleAsync(CreateVehicleDto vehicle)
        {
            var newVehicle = await service.CreateVehicleAsync(vehicle);
            return Ok(newVehicle);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult<Vehicle>> UpdateVehicleAsync(UpdateVehicleDto vehicle)
        {
            try
            {
                var updatedVehicle = await service.UpdateVehicleAsync(vehicle);
                return Ok(updatedVehicle);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<ActionResult<bool>> DeleteVehicleAsync(int id)
        {
            try
            {
                var result = await service.DeleteVehicleAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
