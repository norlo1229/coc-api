using CoCApp.DataAccess.Sql.Contexts;
using CoCApp.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCApp.DataAccess.Sql.Repositories
{
    public class LogsRepository : ILogsRepository
    {
        private readonly AppDbContext context;

        public LogsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Log>> GetLogsAsync(DateTimeOffset beginDate, DateTimeOffset endDate)
        {
            return await context.Logs
                .Where(x => x.TimeStamp >= beginDate && x.TimeStamp <= endDate)
                .OrderByDescending(x => x.TimeStamp)
                .ToListAsync();
        }
    }
}
