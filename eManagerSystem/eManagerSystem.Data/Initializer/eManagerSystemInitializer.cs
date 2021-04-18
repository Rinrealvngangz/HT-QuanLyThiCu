using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eManagerSystem.Data.EF;
namespace eManagerSystem.Data.Initializer
{
   public class eManagerSystemInitializer : CreateDatabaseIfNotExists<eManagerSystemDbContext>
    {
        protected override void Seed(eManagerSystemDbContext context)
        {
            base.Seed(context);
        }
    }
}
