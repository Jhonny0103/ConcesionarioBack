using ConcesionarioBack.Data;
using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;
using ConcesionarioBack.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConcesionarioBack.Services
{
    public class BrandsService: IBrandsService
    {
        private ConcesionarioDbContext context;
        public BrandsService(ConcesionarioDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Brand>> GetBrandsAsync()
        {
            return await this.context.Brands.ToListAsync();
        }

        public async Task<Brand> GetBrandByIdAsync(int id)
        {
            var brand = await this.context.Brands.FindAsync(id);
            if (brand != null)
            {
                return brand;
            }
            else
            {
                throw new Exception($"Brand not found");
            }
        }

        public async Task<Brand> CreateBrandAsync(CreateBrandDto brand)
        {
            Brand newBrand = new Brand
            {
                BrandName = brand.BrandName
            };

            this.context.Brands.Add(newBrand);
            await this.context.SaveChangesAsync();
            return newBrand;
        }

        public async Task<Brand> UpdateBrandAsync(UpdateBrandDto brand)
        {
            var existingBrand = await this.context.Brands.FindAsync(brand.BrandId);
            if (existingBrand != null)
            {
                existingBrand.BrandName = brand.BrandName;
                await this.context.SaveChangesAsync();
                return existingBrand;
            }
            else
            {
                throw new Exception($"Brand not found");
            }
        }

        public async Task<bool> DeleteBrandAsync(int id)
        {
            var existingBrand = await this.context.Brands.FindAsync(id);
            if (existingBrand != null)
            {
                this.context.Brands.Remove(existingBrand);
                await this.context.SaveChangesAsync();
                return true;
            }
            else
            {
                throw new Exception($"Brand not found");
            }
        }
    }
}
