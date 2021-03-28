using CoCApp.DataAccess.Sql.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoCApp.DataAccess.Sql.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options){ }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inspector>()
                .HasMany<InspectorSkill>(i => i.Skills)
                .WithOne(s => s.Inspector)
                .IsRequired();
        }

        public DbSet<Log> Logs { get; set; }
        public DbSet<Inspector> Inspectors { get; set; }
        public DbSet<InspectorSkill> InspectorSkills { get; set; }
        public DbSet<SkillDefinition> SkillDefinitions { get; set; }
        public DbSet<CharacteristicDefinition> CharacteristicDefinitions { get; set; }
        public DbSet<InspectorCharacteristics> InspectorCharacteristics { get; set; }
    }
}
