using _5e_DM_ToolKit_v1.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace _5e_DM_ToolKit_v1.DAL
{
    public class DungeonContext : DbContext
    { 
        public DungeonContext() : base("DungeonContext")
        {

        }

        public DbSet<Characters> Characters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}