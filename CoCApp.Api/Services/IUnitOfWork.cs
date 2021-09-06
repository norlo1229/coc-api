using CoCApp.DataAccess.Sql.Repositories;
using System.Threading.Tasks;

namespace CoCApp.Api.Services
{
    public interface IUnitOfWork
    {
        IInvestigatorRepository Investigators { get; }
        ILogsRepository Logs { get; }
        Task Rollback();
        Task SaveChangesAsync();
    }
}
