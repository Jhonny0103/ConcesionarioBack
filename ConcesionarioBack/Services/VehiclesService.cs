using ConcesionarioBack.Data;
using ConcesionarioBack.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConcesionarioBack.Services
{
    public class VehiclesService
    {
        private ConcesionarioDbContext context;
        public VehiclesService(ConcesionarioDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Vehicle>> GetVehiclesAsync()
        {
            return await context.Vehicles.ToListAsync();
        }
    }
}
