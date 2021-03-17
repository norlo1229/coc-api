using System;
using System.ComponentModel.DataAnnotations;

namespace CoCApp.Domain
{
    public class Log
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Message { get; set; }
        public string MessageTemplate { get; set; }
        [Required]
        public string Level { get; set; }
        public string Exception { get; set; }
        public string Properties { get; set; }
        public string LogEvent { get; set; }
        [Required]
        public DateTimeOffset TimeStamp { get; set; }
    }
}
