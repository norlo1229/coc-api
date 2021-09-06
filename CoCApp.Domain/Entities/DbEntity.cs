using System;
using System.ComponentModel.DataAnnotations;

namespace CoCApp.Domain.Entities
{
    public class DbEntity
    {
        [Required]
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset? LastModifiedDate { get; set; }
    }
}