using Busniss_Logic.GenericRepository;
using InventoryDataAccess.Context;
using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Busniss_Logic.SpecificRepository
{
   public class CategoryService:ICategoryService
    {
        IGeneric<Category> genericservice;
        InvintoryContext context;
        public CategoryService(IGeneric<Category> _genericservice, InvintoryContext _context)
        {
            genericservice = _genericservice;
            context = _context;
        }
        public void insert(Category category)
        {
            genericservice.insert(category);
        }
        public void update(Category category)
        {
            genericservice.update(category);
        }
        public void delete(int id)
        {
            genericservice.delete(id);
        }
        public List<Category> licategory()
        {
            return genericservice.loadall();
        }
        public List<Category> liActiveCategory()
        {
            return context.category.Where(b => b.status == 1).ToList();
        }
        public Category edit(int id)
        {
            return genericservice.edit(id);
        }
        public List<Category> search(string name)
        {
            List<Category> search = context.category.Where(a => a.Name == name).ToList();
            return search;

        }
    }
}
