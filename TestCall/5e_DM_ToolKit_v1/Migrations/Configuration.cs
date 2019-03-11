namespace _5e_DM_ToolKit_v1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_5e_DM_ToolKit_v1.DAL.DungeonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "_5e_DM_ToolKit_v1.DAL.DungeonContext";
        }

        protected override void Seed(_5e_DM_ToolKit_v1.DAL.DungeonContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
