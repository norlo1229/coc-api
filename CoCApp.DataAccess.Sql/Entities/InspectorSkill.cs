using System;
using System.ComponentModel.DataAnnotations;

namespace CoCApp.DataAccess.Sql.Entities
{
    public class InspectorSkill : DbEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid InspectorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MinimumLevel { get; set; }
        public int Level { get; set; }

        //navigation property
        public virtual Inspector Inspector {get;set;}
    }
}
