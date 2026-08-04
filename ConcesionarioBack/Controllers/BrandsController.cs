using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;
using ConcesionarioBack.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ConcesionarioBack.Services.Interfaces;

namespace ConcesionarioBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandsService _service;
        public BrandsController(IBrandsService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<Brand>>> GetBrandsAsync()
        {
            var brands = await _service.GetBrandsAsync();
            return Ok(brands);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<Brand>> GetBrandByIdAsync(int id)
        {
            try
            {
                var brand = await _service.GetBrandByIdAsync(id);
                return Ok(brand);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<Brand>> CreateBrandAsync(CreateBrandDto brand)
        {
            try
            {
                var createdBrand = await _service.CreateBrandAsync(brand);
                return Ok(createdBrand);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult<Brand>> UpdateBrandAsync(UpdateBrandDto brand)
        {
            try
            {
                var updatedBrand = await _service.UpdateBrandAsync(brand);
                return Ok(updatedBrand);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<ActionResult<bool>> DeleteBrandAsync(int id)
        {
            try
            {
                var result = await _service.DeleteBrandAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}
