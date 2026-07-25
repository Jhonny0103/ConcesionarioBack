using ConcesionarioBack.Entities;

namespace ConcesionarioBack.Services.Interfaces
{
    public interface IModelsService
    {
        public Task<List<Model>> GetModelsAsync();
    }
}
