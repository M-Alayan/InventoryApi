using System;
using System.Collections.Generic;
using System.Text;

namespace Busniss_Logic.GenericRepository
{
   public interface IGeneric<T>where T:class
    {
        void insert(T obj);
        void update(T obj);
         void delete(int id);
         List<T> loadall();
        T load();
        T edit(int id);
    }
}
