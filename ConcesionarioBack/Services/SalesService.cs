using ConcesionarioBack.Data;
using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;
using ConcesionarioBack.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConcesionarioBack.Services
{
    public class SalesService: ISalesService
    {
        private ConcesionarioDbContext context;
        public SalesService(ConcesionarioDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Sale>> GetSalesAsync()
        {
            return await this.context.Sales.ToListAsync();
        }

        public async Task<Sale> GetSaleByIdAsync(int id)
        {
            var sale = await this.context.Sales.FindAsync(id);
            if (sale != null)
            {
                return sale;
            }
            else
            {
                throw new Exception($"Sale not found");
            }
        }

        public async Task<Sale> CreateSaleAsync(CreateSaleDto sale)
        {
            Sale newSale = new Sale
            {
                VehicleId = sale.VehicleId,
                CustomerId = sale.CustomerId,
                SalePrice = sale.SalePrice
            };
            this.context.Sales.Add(newSale);
            await this.context.SaveChangesAsync();
            return newSale;
        }

        public async Task<Sale> UpdateSaleAsync(UpdateSaleDto sale)
        {
            var existingSale = await this.context.Sales.FindAsync(sale.SaleId);
            if (existingSale != null)
            {
                existingSale.VehicleId = sale.VehicleId;
                existingSale.CustomerId = sale.CustomerId;
                existingSale.SalePrice = sale.SalePrice;
                await this.context.SaveChangesAsync();
                return existingSale;
            }
            else
            {
                throw new Exception($"Sale not found");
            }
        }

        public async Task<bool> DeleteSaleAsync(int id)
        {
            var existingSale = await this.context.Sales.FindAsync(id);
            if (existingSale != null)
            {
                this.context.Sales.Remove(existingSale);
                await this.context.SaveChangesAsync();
                return true;
            }
            else
            {
                throw new Exception($"Sale not found");
            }
        }
    }
}
