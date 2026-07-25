using ConcesionarioBack.Entities;

namespace ConcesionarioBack.Services.Interfaces
{
    public interface IVehiclesService
    {
        public Task<List<Vehicle>> GetVehiclesAsync();
    }
}
