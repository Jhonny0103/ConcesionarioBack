using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;
using ConcesionarioBack.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConcesionarioBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private BrandsService service;
        public BrandsController(BrandsService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<Brand>>> GetBrandsAsync()
        {
            var brands = await service.GetBrandsAsync();
            return Ok(brands);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<Brand>> GetBrandByIdAsync(int id)
        {
            try
            {
                var brand = await service.GetBrandByIdAsync(id);
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
                var createdBrand = await service.CreateBrandAsync(brand);
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
                var updatedBrand = await service.UpdateBrandAsync(brand);
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
                var result = await service.DeleteBrandAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}
