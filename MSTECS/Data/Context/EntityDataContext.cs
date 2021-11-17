using System;
using Microsoft.EntityFrameworkCore;
using MSTECS.Commun;

namespace MSTECS.Data.Context
{
    public class EntityDataContext:DbContext,IDisposable
    {

        private string _conStr{ set; get; }


        public EntityDataContext(string constr)
        {
            _conStr = constr;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          // optionsBuilder.UseSqlServer(_conStr);
      
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

        #region Entities
        public DbSet<Hability> Employees { set; get; }

        #endregion
    

    
        }
}
