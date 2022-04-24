using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busniss_Logic.SpecificRepository
{
  public  interface IProductService
    {

        void insert(Product product);
        void update(Product product);
        Product edit(int id);

         List<Product> loadAll();
         void delete(int id);
        List<Product> search(string name);
        List<Product> liActiveProduct();
    }
}
