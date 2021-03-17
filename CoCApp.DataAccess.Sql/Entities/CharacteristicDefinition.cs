using System;
using System.ComponentModel.DataAnnotations;

namespace CoCApp.DataAccess.Sql.Entities
{
    public class CharacteristicDefinition : DbEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MinimumLevel { get; set; }
        public int Level { get; set; }
    }
}