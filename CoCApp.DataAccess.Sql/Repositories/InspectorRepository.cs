using CoCApp.DataAccess.Sql.Contexts;
using CoCApp.DataAccess.Sql.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CoCApp.DataAccess.Sql.Repositories
{
    public class InspectorRepository : IInspectorRepository
    {
        private readonly AppDbContext context;

        public InspectorRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Inspector> GetAsync(Guid id)
        {
            return await context.Inspectors
                .Where(i => i.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task Update(Inspector inspector)
        {
            context.Update(inspector);
        }

        public async Task<Inspector> Insert(Inspector inspector)
        {
            var result = await context.AddAsync(inspector);
            return result.Entity;
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
