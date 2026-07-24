using ConcesionarioBack.Entities;
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

        // Seguir mismo patron para los demas controllers
    }
}
