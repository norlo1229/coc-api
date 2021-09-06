using CoCApp.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace CoCApp.DataAccess.Sql.Repositories
{
    public interface IInvestigatorRepository :IGenericRepository<Investigator>
    {
        Task<Investigator> GetInvestigatorAsync(Guid id);
        Task<Investigator> UpdateInvestigatorAsync(Investigator investigator);
    }
}
