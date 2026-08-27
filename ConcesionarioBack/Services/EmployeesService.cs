using ConcesionarioBack.Data;
using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;
using ConcesionarioBack.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConcesionarioBack.Services
{
    public class EmployeesService : IEmployeesService
    {
        private ConcesionarioDbContext context;

        public EmployeesService(ConcesionarioDbContext context)
        {
            this.context = context;
        }

        //Login
        public async Task<Employe> GetLogin(AuthLoginDto login)
        {
            return await this.context.Employees.FirstOrDefaultAsync(c => c.EmployeName == login.Name && c.EmployeEmail == login.Email && c.IsActive);
        }

        public async Task<List<Employe>> GetEmployeesAsync()
        {
            return await this.context.Employees.ToListAsync();
        }

        public async Task<Employe> GetEmployeeByIdAsync(int id)
        {
            var employee = await this.context.Employees.FindAsync(id);
            if (employee != null)
            {
                return employee;
            }
            else
            {
                throw new Exception($"Employee not found");
            }
        }

        public async Task<Employe> CreateEmployeeAsync(CreateEmployeDto employe)
        {
            Employe newEmploye = new Employe
            {
                EmployeName = employe.EmployeName,
                EmployeEmail = employe.EmployeEmail,
                EmployePhone = employe.EmployePhone
            };

            this.context.Employees.Add(newEmploye);
            await this.context.SaveChangesAsync();
            return newEmploye;
        }

        public async Task<Employe> UpdateEmployeeAsync(UpdateEmployeDto employe)
        {
            var existingEmploye = await this.context.Employees.FindAsync(employe.EmployeId);
            if (existingEmploye != null)
            {
                existingEmploye.EmployeName = employe.EmployeName;
                existingEmploye.EmployeEmail = employe.EmployeEmail;
                existingEmploye.EmployePhone = employe.EmployePhone;
                existingEmploye.IsActive = employe.IsActive;
                await this.context.SaveChangesAsync();
                return existingEmploye;
            }
            else
            {
                throw new Exception($"Employee not found");
            }
        }

        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            var existingEmploye = await this.context.Employees.FindAsync(id);
            if (existingEmploye != null)
            {
                this.context.Employees.Remove(existingEmploye);
                await this.context.SaveChangesAsync();
                return true;
            }
            else
            {
                throw new Exception($"Employee not found");
            }
        }

    }
}
