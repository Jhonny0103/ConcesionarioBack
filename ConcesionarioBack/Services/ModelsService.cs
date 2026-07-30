using ConcesionarioBack.Data;
using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;
using ConcesionarioBack.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConcesionarioBack.Services
{
    public class ModelsService: IModelsService
    {
        private ConcesionarioDbContext context;
        public ModelsService(ConcesionarioDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Model>> GetModelsAsync()
        {
            return await context.Models.ToListAsync();
        }

        public async Task<Model> GetModelByIdAsync(int id)
        {
            var model = await context.Models.FindAsync(id);
            if (model != null)
            {
                return model;
            }
            else
            {
                throw new Exception($"Model not found");
            }
        }

        public async Task<Model> CreateModelAsync(CreateModelDto model)
        {
            Model newModel = new Model
            {
                ModelName = model.ModelName
            };
            context.Models.Add(newModel);
            await context.SaveChangesAsync();
            return newModel;
        }

        public async Task<Model> UpdateModelAsync(UpdateModelDto model)
        {
            var existingModel = await context.Models.FindAsync(model.ModelId);
            if (existingModel != null)
            {
                existingModel.ModelName = model.ModelName;
                await context.SaveChangesAsync();
                return existingModel;
            }
            else
            {
                throw new Exception($"Model not found");
            }
        }

        public async Task<bool> DeleteModelAsync(int id)
        {
            var existingModel = await context.Models.FindAsync(id);
            if (existingModel != null)
            {
                context.Models.Remove(existingModel);
                await context.SaveChangesAsync();
                return true;
            }
            else
            {
                throw new Exception($"Model not found");
            }
        }
    }
}
