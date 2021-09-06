using CoCApp.DataAccess.Sql.Contexts;
using CoCApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoCApp.DataAccess.Sql.Repositories
{
    public class LogsRepository : Repository<Log>, ILogsRepository
    {
        public LogsRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Log>> GetLogsAsync(DateTimeOffset startDate, DateTimeOffset endDate)
        {
            var results = await context.Logs.Where(x => x.TimeStamp >= startDate && x.TimeStamp <= endDate).ToListAsync();
            return results;
        }
    }
}
