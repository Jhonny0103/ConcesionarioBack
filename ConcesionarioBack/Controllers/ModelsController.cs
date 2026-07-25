using ConcesionarioBack.Entities;
using ConcesionarioBack.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConcesionarioBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private ModelsService service;
        public ModelsController(ModelsService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<Model>>> GetModelsAsync()
        {
            var models = await service.GetModelsAsync();
            return Ok(models);
        }
    }
}
