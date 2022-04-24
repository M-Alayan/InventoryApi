using Busniss_Logic.GenericRepository;
using InventoryDataAccess.Context;
using InventoryDataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Busniss_Logic.SpecificRepository
{
   public class ProductService:IProductService
    {
        private readonly IGeneric<Product> generic;
        private readonly InvintoryContext context;

        public ProductService(IGeneric<Product> _generic,InvintoryContext _context)
        {
            generic = _generic;
            context = _context;
        }

        public void insert(Product product)
        {
            generic.insert(product);
        }

        public void update(Product product)
        {
            generic.update(product);
            
        }
        public Product edit(int id)
        {
            return generic.edit(id);
        }

        public void delete(int id)
        {
            generic.delete(id);
        }
        //public List<Product> loadAll()
        //{
        //    return generic.loadall();
        //}
        public List<Product> loadAll()
        {
            List<Product> liproduct = context.product.Include("store").ToList();
            return liproduct;
        }
        public List<Product> liActiveProduct()
        {
            return context.product.Where(b => b.Availabilty == 0).ToList();
        }

        public List<Product> search(string name)
        {
            List<Product> search = context.product.Where(a => a.Name == name).ToList();
            return search;
        }
       
    }
}
