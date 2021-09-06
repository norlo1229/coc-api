using CoCApp.DataAccess.Sql.Contexts;
using CoCApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CoCApp.DataAccess.Sql.Repositories
{
    public class InvestigatorRepository : Repository<Investigator>, IInvestigatorRepository
    {
        public InvestigatorRepository(AppDbContext context) : base(context){}

        public async Task<Investigator> GetInvestigatorAsync(Guid id)
        {
            return await context.Investigator
                .Where(x => x.Id == id)
                .Include(x => x.PersonalInformation)
                .Include(x => x.Characteristics)
                .FirstOrDefaultAsync();
        }

        public async Task<Investigator> UpdateInvestigatorAsync(Investigator investigator)
        {
            return context.Investigator.Update(investigator).Entity;
        }
    }
}
