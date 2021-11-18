using Microsoft.EntityFrameworkCore;
using MSTECS.Commun;

namespace MSTECS.Data.Context
{
    interface IEntityDataContext

    {
        /// <summary>
        /// variable string _conStr
        /// </summary>    
        string _conStr { set; get; }
        /// <summary>
        /// Method configuring
        /// </summary>
        /// <param name="optionsBuilder"></param>
        void OnConfiguring(DbContextOptionsBuilder optionsBuilder);
        /// <summary>
        /// Variable constr occupated in other class in project
        /// </summary>
        /// <param name="constr"></param>
        /// <returns></returns> 
        IEntityDataContext EntityDataContext(string constr);
    }
    /// <summary>
    /// Class the  interface IEntityContext with method connect database and configuring
    /// </summary>
    public class entityDataContext : IEntityDataContext
    {
        public string _conStr { get; set; }
        public entityDataContext(string constr)
        {
            _conStr = constr;
        }
        public void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
    
            optionsBuilder.EnableSensitiveDataLogging();
            OnConfiguring(optionsBuilder);
        }

        public IEntityDataContext EntityDataContext(string constr)
        {
            _conStr = constr;
            return EntityDataContext(_conStr);
        }

        #region Entities
        public DbSet<Hability> Habilidades { set; get; }
        #endregion

    }
}