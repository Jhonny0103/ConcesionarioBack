using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;

namespace ConcesionarioBack.Services.Interfaces
{
    public interface IVehiclesService
    {
        public Task<List<Vehicle>> GetVehiclesAsync();
        public Task<Vehicle> GetVehicleByIdAsync(int id);
        public Task<Vehicle> CreateVehicleAsync(CreateVehicleDto vehicle);
        public Task<Vehicle> UpdateVehicleAsync(UpdateVehicleDto vehicle);
        public Task<bool> DeleteVehicleAsync(int id);
    }
}
