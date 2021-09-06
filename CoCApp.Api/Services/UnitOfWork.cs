using CoCApp.DataAccess.Sql.Contexts;
using CoCApp.DataAccess.Sql.Repositories;
using System;
using System.Threading.Tasks;

namespace CoCApp.Api.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        AppDbContext context;
        private readonly IInvestigatorRepository investigatorRepository;
        private readonly ILogsRepository logsRepository;

        public IInvestigatorRepository Investigators => investigatorRepository;

        public ILogsRepository Logs => logsRepository;

        public UnitOfWork(AppDbContext context)
        {
            this.context = context;
            investigatorRepository = new InvestigatorRepository(context);
            logsRepository = new LogsRepository(context);
        }


        public Task Rollback()
        {
            throw new NotImplementedException();
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
