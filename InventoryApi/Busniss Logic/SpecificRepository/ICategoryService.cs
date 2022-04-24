using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busniss_Logic.SpecificRepository
{
   public interface ICategoryService
    {
        void insert(Category category);

        void delete(int id);
        void update(Category category);
        List<Category> licategory();
        Category edit(int id);
        List<Category> search(string name);
        List<Category> liActiveCategory();
    }
}
