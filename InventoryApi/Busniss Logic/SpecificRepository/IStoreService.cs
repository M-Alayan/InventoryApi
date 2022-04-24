using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busniss_Logic.SpecificRepository
{
  public  interface IStoreService
    {
        void insert(Store store);

        void delete(int id);
        void update(Store store);
        List<Store> listore();
        Store edit(int id);
        List<Store> search(string name);
        List<Store> liActiveStore();
    }
}
