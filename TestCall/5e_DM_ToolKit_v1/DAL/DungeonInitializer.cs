using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _5e_DM_ToolKit_v1.DAL
{
    public class DungeonInitializer : CreateDatabaseIfNotExists<DungeonContext>
    {
        protected override void Seed(DungeonContext context)
        {
            base.Seed(context);
        }

    }
}