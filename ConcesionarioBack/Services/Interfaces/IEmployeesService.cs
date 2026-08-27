using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;

namespace ConcesionarioBack.Services.Interfaces
{
    public interface IEmployeesService
    {
        public Task<Employe> GetLogin(AuthLoginDto login);
        public Task<List<Employe>> GetEmployeesAsync();
        public Task<Employe> GetEmployeeByIdAsync(int id);
        public Task<Employe> CreateEmployeeAsync(CreateEmployeDto employe);
        public Task<Employe> UpdateEmployeeAsync(UpdateEmployeDto employe);
        public Task<bool> DeleteEmployeeAsync(int id);
    }
}
