using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoCApp.DataAccess.Sql.Entities
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
        [Column(TypeName = "xml")]
        public string Properties { get; set; }
        public string LogEvent { get; set; }
        [Required]
        public DateTimeOffset TimeStamp { get; set; }
    }
}
