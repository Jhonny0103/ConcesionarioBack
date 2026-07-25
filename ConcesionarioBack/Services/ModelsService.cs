using ConcesionarioBack.Data;
using ConcesionarioBack.Entities;
using ConcesionarioBack.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConcesionarioBack.Services
{
    public class ModelsService: IModelsService
    {
        private ConcesionarioDbContext context;
        public ModelsService(ConcesionarioDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Model>> GetModelsAsync()
        {
            return await context.Models.ToListAsync();
        }
    }
}
