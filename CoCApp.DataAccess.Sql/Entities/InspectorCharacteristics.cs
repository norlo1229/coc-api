using System;
using System.ComponentModel.DataAnnotations;

namespace CoCApp.DataAccess.Sql.Entities
{
    public class InspectorCharacteristics : DbEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid InspectorId { get; set; }
        [Required]
        public int Str { get; set; }
        [Required]
        public int Dex { get; set; }
        [Required]
        public int Int { get; set; }
        [Required]
        public int Con { get; set; }
        [Required]
        public int App { get; set; }
        [Required]
        public int Pow { get; set; }
        [Required]
        public int Siz { get; set; }
        [Required]
        public int Edu { get; set; }
        [Required]
        public int Luck { get; set; }
        [Required]
        public int MoveRate { get; set; }
        [Required]
        public int HitPoints { get; set; }
        [Required]
        public int Sanity { get; set; }
        [Required]
        public int MagicPoints { get; set; }
        public virtual Inspector Inspector { get; set; }
    }
}
