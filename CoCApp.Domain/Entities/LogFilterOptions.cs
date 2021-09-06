using System;

namespace CoCApp.Domain.Entities
{
    public class LogFilterOptions
    {
        public DateTimeOffset? BeginDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public string LogLevel { get; set; }
    }
}
