using TeamAlpha.GoldenOracle.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TeamAlpha.GoldenOracle.DAL
{
    public class DungeonContext : DbContext
    { 
        public DungeonContext() : base("DungeonContext")
        {
            Database.SetInitializer(new DungeonInitializer());

        }

        public DbSet<Characters> Characters { get; set; }
        public DbSet<Monsters> Monsters { get; set; }
        //public DbSet<Classes> Classes { get; set; }
        //public DbSet<Races> Races { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<_5e_DM_ToolKit_v1.Models.Races> Races { get; set; }
    }
}