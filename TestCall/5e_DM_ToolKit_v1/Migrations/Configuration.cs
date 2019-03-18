namespace TeamAlpha.GoldenOracle.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TeamAlpha.GoldenOracle.DAL.DungeonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TeamAlpha.GoldenOracle.DAL.DungeonContext";
        }

        protected override void Seed(TeamAlpha.GoldenOracle.DAL.DungeonContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
