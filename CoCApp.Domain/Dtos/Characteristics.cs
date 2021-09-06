using System;

namespace CoCApp.Domain.Dtos
{
    public class Characteristics
    {
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
    }
}