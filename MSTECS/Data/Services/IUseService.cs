using MSTECS.Commun;
using MSTECS.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSTECS.Data
{
    public   interface IUseService : IDisposable
    {
        #region MyRegionIterface
        //IEmployeeService employeeService(IFactoryTest factory);
        #endregion
        #region MyRegionList
        List<Hability> Get();
        List<Hability> Get(Guid id);

        #endregion
        #region MyRegionConsultSQL
        Hability create(Hability item);
        void Update(String Name);
        Hability SelectList(Hability item);
        Hability Selectfilter(Hability item);
        void Deleted(Guid iud_user);
        #endregion

    }
    /// <summary>
    /// Class use Interface Principal
    /// </summary>
    public class useService : IUseService
    {


        public EntityDataContext context;

        private Guid id;

        public string _conStr { get; set; }
        /// <summary>
        /// return list data
        /// </summary>
        /// <returns></returns>
        public List<Hability> Get()
        {
            return context.habilities.ToList();

        }
        /// <summary>
        /// id user create
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Hability> Get(Guid id)
        {
            return context.habilities.Where(s => id.Equals(s.IdUser)).ToList();
        }
        
        /// <summary>
        /// Consult create profile user
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Hability create(Hability item)
        {
            item.IdUser = Guid.NewGuid();
            context.habilities.Add(item);

           
            return item;

        }
        /// <summary>
        /// Consult filter for name
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Hability Selectfilter(Hability item)
        {

          
            var query = context.habilities.Where(s => s.Name.Contains(item.Name)).ToList();
            foreach (var n in query)
            {
                Console.Write("\n" + n.IdUser + "\t" + n.Name );
            }
            return item;
        }
        /// <summary>
        /// Consult for view list
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Hability SelectList(Hability item)
        {
            var query = (from s in context.habilities select s.IdUser + "\t" + s.Name + "\t" + s.LastName + "\t" + s.Number + "\t" + s.Direction + "\t" + s.Habiliti + "\t" +s.Hability2).ToList();
            foreach (string n in query)
            {
                Console.Write("\n" + n);
            }
            // context.Update(item);
            return item;
        }
        /// <summary>
        /// consult Update date
        /// </summary>
        /// <param name="Name"></param>
        public void Update(string Name)
        {
            var query = context.habilities.Where(s => s.Name.Equals(s.Name));
            if (query.Any()) context.habilities.Local.Remove(query.First());
            //  context.Update(query);
        }



        /// <summary>
        /// Consult deleted
        /// </summary>
        /// <param name="iud_user"></param>
        public void Deleted(Guid iud_user)
        {
            var query = context.habilities.First(s => s.IdUser.Equals(id));
          
        }
        /*
        IEmployeeService IEmployeeService.employeeService(IFactoryTest factory)
        {
            context = factory;
            //return context;
            
        }*/

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }


}
