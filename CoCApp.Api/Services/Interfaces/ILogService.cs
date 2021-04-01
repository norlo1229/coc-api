using CoCApp.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoCApp.Api.Services.Interfaces
{
    public interface ILogService
    {
        Task<IEnumerable<Log>> GetFilteredLogsAsync(LogFilterOptions filters);
    }
}
