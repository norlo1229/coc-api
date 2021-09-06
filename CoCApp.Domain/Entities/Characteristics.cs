using System;
using System.ComponentModel.DataAnnotations;

namespace CoCApp.Domain.Entities
{
    public class Characteristics : DbEntity
    {
        [Key]
        public Guid Id { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Apperance { get; set; }
        public int Intelligence { get; set; }
        public int Size { get; set; }
        public int Power { get; set; }
        public int Education { get; set; }
        public int Luck { get; set; }

        public Guid InvestigatorId { get; set; }
        public Investigator Investigator { get; set; }
    }
}