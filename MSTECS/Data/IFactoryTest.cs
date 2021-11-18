using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using Microsoft.EntityFrameworkCore;
using MSTECS.Data;
using MSTECS.Data.Context;
namespace MSTECS.Data
{
   public interface IFactoryTest :IDisposable
    {

        // IEntityDataContext  entityDataContext (IEntityDataContext _context);
        // IEntityDataContext EntityDataContext(IEntityDataContext _context);

        /// <summary>
        /// Context connection database
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        IFactoryTest FactoryTest(IEntityDataContext context);
        /// <summary>
        /// Method Save changes
        /// </summary>
        void SaveChanges();
        /// <summary>
        /// Method Deleted
        /// </summary>
        void DeletedChanges();
        /// <summary>
        /// Method SelectChanges
        /// </summary>
        void SelectChanges();
        /// <summary>
        /// Method Select Employee
        /// </summary>
        void SelectEmployee();
        /// <summary>
        /// Method SelectFilter
        /// </summary>
        void SelectFilter();
    }

    /// <summary>
    /// class factory extends IFactorytest interface
    /// </summary>
    public class factoryTest : IFactoryTest
    {
        public string _conStr { get; set; }
        /// <summary>
        /// save changes  generated in deleted id table Empleado
        /// </summary>
        public void DeletedChanges()
        {
            using (var transaction = new TransactionScope())
            {
                SaveChanges();
                transaction.Complete();
            }
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEntityDataContext EntityDataContext(IEntityDataContext _context)
        {
            throw new NotImplementedException();
        }

        public IFactoryTest FactoryTest(IEntityDataContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Connection DATABASE
        /// </summary>
        /// <param name="constr"></param>

        /// <summary>
        /// Send call a connection database
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        /// <summary>
        /// save changes  generated
        /// </summary>
        public void SaveChanges()
        {
            using (var transaction = new TransactionScope())
            {

                SaveChanges();
                transaction.Complete();
            }
        }
        /// <summary>
        /// save changes  generated in Select Changes
        /// </summary>
        public void SelectChanges()
        {
            using (var trasnsition = new TransactionScope())
            {
                Dispose();
                trasnsition.Complete();
            }
        }
        /// <summary>
        /// save changes  generated in SelectEmployee
        /// </summary>
        public void SelectEmployee()
        {
            using (var trasnsition = new TransactionScope())
            {
                Dispose();
                trasnsition.Complete();
            }
        }
        /// <summary>
        /// save changes  generated select filter
        /// </summary>
        public void SelectFilter()
        {
            using (var trasnsition = new TransactionScope())
            {
                Dispose();
                trasnsition.Complete();
            }
        }


    }
}
