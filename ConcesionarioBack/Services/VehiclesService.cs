using ConcesionarioBack.Data;
using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;
using ConcesionarioBack.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConcesionarioBack.Services
{
    public class VehiclesService: IVehiclesService
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

        public async Task<Vehicle> GetVehicleByIdAsync(int id)
        {
            var vehicle = await context.Vehicles.FindAsync(id);
            if (vehicle != null)
            {
                return vehicle;
            }
            else
            {
                throw new Exception($"Vehicle with id {id} not found.");

            }
        }

        public async Task<Vehicle> CreateVehicleAsync(CreateVehicleDto vehicle)
        {
            Vehicle newVehicle = new Vehicle
            {
                ModelId = vehicle.ModelId,
                BrandId = vehicle.BrandId,
                LicensePlate = vehicle.LicensePlate,
                Color = vehicle.Color,
                Year = vehicle.Year,
                Price = vehicle.Price
            };
            context.Vehicles.Add(newVehicle);
            await context.SaveChangesAsync();
            return newVehicle;
        }

        public async Task<Vehicle> UpdateVehicleAsync(UpdateVehicleDto vehicle)
        {
            var existingVehicle = await context.Vehicles.FindAsync(vehicle.VehicleId);
            if (existingVehicle != null)
            {
                existingVehicle.ModelId = vehicle.ModelId;
                existingVehicle.BrandId = vehicle.BrandId;
                existingVehicle.LicensePlate = vehicle.LicensePlate;
                existingVehicle.Color = vehicle.Color;
                existingVehicle.Year = vehicle.Year;
                existingVehicle.Price = vehicle.Price;
                await context.SaveChangesAsync();
                return existingVehicle;
            }
            else
            {
                throw new Exception($"Vehicle not found.");
            }
        }

        public async Task<bool> DeleteVehicleAsync(int id)
        {
            var existingVehicle = await context.Vehicles.FindAsync(id);
            if (existingVehicle != null)
            {
                context.Vehicles.Remove(existingVehicle);
                await context.SaveChangesAsync();
                return true;
            }
            else
            {
                throw new Exception($"Vehicle not found.");
            }
        }
    }
}
