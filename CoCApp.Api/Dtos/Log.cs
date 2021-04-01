using System;
using System.ComponentModel.DataAnnotations;

namespace CoCApp.Api.Dtos
{
    public class Log
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public string Level { get; set; }
        public string Exception { get; set; }
        [Required]
        public DateTimeOffset TimeStamp { get; set; }
    }
}
