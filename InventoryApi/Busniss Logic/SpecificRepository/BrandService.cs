using Busniss_Logic.GenericRepository;
using InventoryDataAccess.Context;
using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Busniss_Logic.SpecificRepository
{
   public class BrandService:IBrandService
    {
        IGeneric<Brand> generic;
        InvintoryContext context;
        public BrandService(IGeneric<Brand> _generic,InvintoryContext _context)
        {
            generic = _generic;
            context = _context;
        }

        public void insert(Brand brand)
        {
            generic.insert(brand);
        }
        public void update(Brand brand)
        {
            generic.update(brand);
        }
        public void delete(int id)
        {
            generic.delete(id);
        }
        public List<Brand> librand()
        {
            return generic.loadall();
        }

        public List<Brand> liActiveBrand()
        {
            return context.brand.Where(b=>b.status==1).ToList();
        }
        public Brand edit(int id)
        {
            return generic.edit(id);
        }
        public List<Brand> search(string name)
        {
            List<Brand> search = context.brand.Where(a => a.Name == name).ToList();
            return search;

        }
    }
}
