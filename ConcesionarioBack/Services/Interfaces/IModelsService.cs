using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;

namespace ConcesionarioBack.Services.Interfaces
{
    public interface IModelsService
    {
        public Task<List<Model>> GetModelsAsync();
        public Task<Model> GetModelByIdAsync(int id);
        public Task<Model> CreateModelAsync(CreateModelDto model);
        public Task<Model> UpdateModelAsync(UpdateModelDto model);
        public Task<bool> DeleteModelAsync(int id);
    }
}
