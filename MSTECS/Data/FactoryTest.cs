using MSTECS.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace MSTECS.Data
{
   public class FactoryTest :IDisposable
    {
        public EntityDataContext _context;
        /// <summary>
        /// Conectiom database
        /// </summary>
        /// <param name="context"></param>
        public FactoryTest(EntityDataContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Disponibilidad
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
        }
        /// <summary>
        /// transaction data in DataBase
        /// </summary>
        public void SaveChanges()
        {
            using (var transaction = new TransactionScope())
            {
                _context.SaveChanges();
                transaction.Complete();
            }
        }
        /// <summary>
        /// Deleted transition
        /// </summary>
        public void DeletedChanges()
        {
            using (var transaction = new TransactionScope())
            {
                _context.SaveChanges();
                transaction.Complete();
            }
        }
        /// <summary>
        /// Select transition
        /// </summary>
        public void SelectChanges()
        {
            using (var trasnsition = new TransactionScope())
            {
                _context.Dispose();
                trasnsition.Complete();
            }
        }
        /// <summary>
        /// Select employee insert 
        /// </summary>
        public void SelectEmployee()
        {
            using (var trasnsition = new TransactionScope())
            {
                _context.Dispose();
                trasnsition.Complete();
            }
        }
        public void SelectFilter()
        {
            using (var trasnsition = new TransactionScope())
            {
                _context.Dispose();
                trasnsition.Complete();
            }
        }


    }
}

