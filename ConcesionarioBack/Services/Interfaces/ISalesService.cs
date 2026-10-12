using ConcesionarioBack.Entities;
using ConcesionarioBack.Entities.Views;
using ConcesionarioBack.Models.Requests;

namespace ConcesionarioBack.Services.Interfaces
{
    public interface ISalesService
    {
        public Task<List<Sale>> GetSalesAsync();
        public Task<List<VwSaleDetails>> GetSalesDetailsAsync();
        public Task<Sale> GetSaleByIdAsync(int id);
        public Task<Sale> CreateSaleAsync(CreateSaleDto sale);
        public Task<Sale> UpdateSaleAsync(UpdateSaleDto sale);
        public Task<bool> DeleteSaleAsync(int id);
    }
}
