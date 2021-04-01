using CoCApp.Api.Services.Interfaces;
using CoCApp.DataAccess.Sql.Repositories;
using CoCApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoCApp.Api.Services
{
    public class LogService : ILogService
    {
        private readonly ILogsRepository logRepository;

        public LogService(ILogsRepository logRepository)
        {
            this.logRepository = logRepository;
        }

        public async Task<IEnumerable<Log>> GetFilteredLogsAsync(LogFilterOptions filters)
        {
            var finalBeginDate = filters.BeginDate ?? DateTimeOffset.Now.AddDays(-90);
            var finalEndDate = filters.EndDate ?? DateTimeOffset.Now;

            var logs = await logRepository.GetLogsAsync(finalBeginDate, finalEndDate);

            if (!string.IsNullOrWhiteSpace(filters.LogLevel))
            {
                logs = logs.Where(x => x.Level.ToLower() == filters.LogLevel.ToLower());
            }

            return logs;
        }
    }
}
