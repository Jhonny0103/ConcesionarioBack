using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;
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

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<Model>> GetModelByIdAsync(int id)
        {
            var model = await service.GetModelByIdAsync(id);
            return Ok(model);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<Model>> CreateModelAsync(CreateModelDto model)
        {
            var newModel = await service.CreateModelAsync(model);
            return Ok(newModel);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult<Model>> UpdateModelAsync(UpdateModelDto model)
        {
            var updatedModel = await service.UpdateModelAsync(model);
            return Ok(updatedModel);
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<ActionResult<bool>> DeleteModelAsync(int id)
        {
            var result = await service.DeleteModelAsync(id);
            return Ok(result);
        }
    }
}
