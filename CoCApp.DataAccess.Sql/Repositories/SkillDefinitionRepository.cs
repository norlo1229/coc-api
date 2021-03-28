using CoCApp.DataAccess.Sql.Contexts;
using CoCApp.DataAccess.Sql.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoCApp.DataAccess.Sql.Repositories
{
    public class SkillDefinitionRepository : IRepository<SkillDefinition>
    {
        private readonly AppDbContext context;

        public SkillDefinitionRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<SkillDefinition>> GetAllAsync()
        {
            return await context.SkillDefinitions.ToListAsync();
        }

        public async Task<SkillDefinition> GetAsync(Guid id)
        {
            return await context.SkillDefinitions
                .Where(s => s.Id == id)
                .FirstOrDefaultAsync();
        }

        public Task<SkillDefinition> InsertAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
