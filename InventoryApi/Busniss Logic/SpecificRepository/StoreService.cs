using Busniss_Logic.GenericRepository;
using InventoryDataAccess.Context;
using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Busniss_Logic.SpecificRepository
{
  public class StoreService:IStoreService
    {
        private readonly IGeneric<Store> genericservice;
        InvintoryContext context;
        public StoreService(IGeneric<Store> _genericservice, InvintoryContext _context)
        {
            genericservice = _genericservice;
            context = _context;
        }

        public void insert(Store store)
        {
            genericservice.insert(store);
        }
        public void update(Store store)
        {
            genericservice.update(store);
        }
        public void delete(int id)
        {
            genericservice.delete(id);
        }
        public List<Store> listore()
        {
            return genericservice.loadall();
        }
        public List<Store> liActiveStore()
        {
            return context.store.Where(b => b.status == 1).ToList();
        }
        public Store edit(int id)
        {
            return genericservice.edit(id);
        }
        public List<Store> search(string name)
        {
            List<Store> search = context.store.Where(a => a.Name == name).ToList();
            return search;

        }
    }
}
