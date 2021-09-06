using CoCApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoCApp.DataAccess.Sql.Repositories
{
    public interface ILogsRepository : IGenericRepository<Log>
    {
        Task<IEnumerable<Log>> GetLogsAsync(DateTimeOffset beginDate, DateTimeOffset endDate);
    }
}
