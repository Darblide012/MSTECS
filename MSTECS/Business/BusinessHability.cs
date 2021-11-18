using MSTECS.Commun;
using MSTECS.Comun;
using MSTECS.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSTECS.Business
{
   public  class BusinessHability
    {

        private FactoryTest Factory { set; get; }
        private UseService useService { set; get; }
        public BusinessHability(FactoryTest factory, UseService service)
        {
            Factory = factory;
            useService = service;
        }
        /// <summary>
        /// Deleted operation call in program
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public OperationResult DeleteEmployee(Hability user)
        {
            var result = new OperationResult();
            try
            {
                using (Factory)
                {
                    useService.Delete(user.IdUser);
                    result.Success = false;/// tHIS IS BAND 
                    Factory.SaveChanges();
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
                return result;
            }
        }
        /// <summary>
        /// Create operation call in program
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public OperationResult CreateUser(Hability user)
        {
            var result = new OperationResult();
            try
            {
                using (Factory)
                {
                    result.Data = useService.Create(user);
                    result.Success = false;
                    Factory.SaveChanges();
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
                return result;
            }
        }
        /// <summary>
        /// Select operation call in program
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public OperationResult SelectList(Hability user)
        {
            var result = new OperationResult();
            try
            {
                using (Factory)
                {
                    result.Data = useService.SelectList(user);
                    Factory.SelectEmployee();
                    result.Success = false;
                    return result;
                }
            }

            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
                return result;
            }
        }
        /// <summary>
        /// Show list data
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public OperationResult Selectfilter(Hability user)
        {
            var result = new OperationResult();
            try
            {
                using (Factory)
                {
                    result.Data = useService.Selectfilter(user);
                    Factory.SelectFilter();
                    result.Success = false;
                    return result;
                }
            }

            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
                return result;
            }

        }
        /// <summary>
        /// Update Field date
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public OperationResult Updated(Hability user)
        {
            var result = new OperationResult();
            try
            {
                using (Factory)
                {
                    useService.Update(user.Name);
                    Factory.SelectChanges();
                    result.Success = false;
                    return result;
                }
            }

            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
                return result;
            }
        }
    }
}
