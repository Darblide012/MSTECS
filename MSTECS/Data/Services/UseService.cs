using MSTECS.Commun;
using MSTECS.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MSTECS.Data
{
    public  class UseService 
    {
    
    private EntityDataContext _context;

    public UseService(FactoryTest factory)
    {
        _context = factory._context;
    }
    public List<Hability> Get()
    {
        return _context.habilities.ToList();
            
    }
    /// <summary>
    /// Create List for id user
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public List<Hability> Get(Guid id)
    {
        return _context.habilities.Where(s => id.Equals(s.IdUser)).ToList();
           
    }
    /// <summar
    public List<Hability> Get( String   Name )
     {
         return _context.habilities.Where(s => Name.Equals(s.Name)).ToList();

     }
    /// <summary>
    /// Create 
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public Hability Create(Hability item)
    {
        item.IdUser = Guid.NewGuid();
   
        _context.habilities.Add(item);

       
        return item;

    }
    /// <summary>
    /// Update
    /// </summary>
    /// <param name="item"></param>
    public void Update(String Name)
    {
        var query = _context.habilities.Where(s => s.Name.Equals(s.Name));
        if (query.Any()) _context.habilities.Local.Remove(query.First());
        _context.Update(query);
    }
    /// <summary>
    /// Deleted, Note in delete a level logic never delete field
    /// </summary>
    /// <param name="item"></param>
    public void Delete(Guid id)
    {
        var query = _context.habilities.First(s => s.IdUser.Equals(id));
        

    }
    public Hability SelectList(Hability item)
    {
        var query = (from s in _context.habilities select s.IdUser + "\t" + s.Name + "\t" + s.LastName + "\t" + s.Number + "\t" + s.Direction + "\t" + s.Email + "\t" +s.Habiliti + "\t" +s.Hability2).ToList();
        foreach (string n in query)
        {
            Console.Write("\n" + n);
        }
        _context.Update(item);
        return item;
    }
    /// <summary>
    /// From
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public Hability Selectfilter(Hability item)
    {

        var query = _context.habilities.Where(s => s.Name.Contains(item.Name)).ToList();
        foreach (var n in query)
        {
            Console.Write("\n" + n.IdUser + "\t" + n.Name + "\t" );
        }
        return item;
      


    }   
    
    
    }

    
}
