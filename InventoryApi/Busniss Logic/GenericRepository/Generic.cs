using InventoryDataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Busniss_Logic.GenericRepository
{
   public class Generic<T>:IGeneric<T> where T:class
    {
        InvintoryContext context;
        public Generic(InvintoryContext _context)
        {
            context = _context;
        }


        public void insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }
        public  void update(T obj)
        {
            context.Set<T>().Attach(obj);
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
        public void delete(int id)
        {
            T obj = context.Set<T>().Find(id);
            context.Set<T>().Remove(obj);
            context.SaveChanges();
        }
        public List<T> loadall()
        {
            return context.Set<T>().ToList();
        }

        public T load()
        {
            return context.Set<T>().FirstOrDefault();
        }
        public T edit(int id)
        {
            T obj = context.Set<T>().Find(id);
            return obj;
        }
       
    }
}
