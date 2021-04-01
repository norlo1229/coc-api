using CoCApp.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoCApp.DataAccess.Sql.Repositories
{
    public interface ILogsRepository
    {
        Task<IEnumerable<Log>> GetLogsAsync(DateTimeOffset beginDate, DateTimeOffset endDate);
    }
}
