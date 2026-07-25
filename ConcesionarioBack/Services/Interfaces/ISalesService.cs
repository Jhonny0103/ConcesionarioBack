using ConcesionarioBack.Entities;

namespace ConcesionarioBack.Services.Interfaces
{
    public interface ISalesService
    {
        public Task<List<Sale>> GetSalesAsync();
    }
}
