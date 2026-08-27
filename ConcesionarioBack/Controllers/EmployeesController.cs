using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;
using ConcesionarioBack.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConcesionarioBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesService _service;

        public EmployeesController(IEmployeesService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<Employe>>> GetEmployeesAsync()
        {
            var employees = await _service.GetEmployeesAsync();
            return Ok(employees);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<Employe>> GetEmployeeByIdAsync(int id)
        {
            try
            {
                var employee = await _service.GetEmployeeByIdAsync(id);
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<Employe>> CreateEmployeeAsync(CreateEmployeDto employee)
        {
            try
            {
                var createdEmployee = await _service.CreateEmployeeAsync(employee);
                return Ok(createdEmployee);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult<Employe>> UpdateEmployeeAsync(UpdateEmployeDto employee)
        {
            try
            {
                var updatedEmployee = await _service.UpdateEmployeeAsync(employee);
                return Ok(updatedEmployee);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<ActionResult> DeleteEmployeeAsync(int id)
        {
            try
            {
                await _service.DeleteEmployeeAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        
    }
}
