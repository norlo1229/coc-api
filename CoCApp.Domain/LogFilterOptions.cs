using System;

namespace CoCApp.Domain
{
    public class LogFilterOptions
    {
        public DateTimeOffset? BeginDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public string LogLevel { get; set; }
    }
}
