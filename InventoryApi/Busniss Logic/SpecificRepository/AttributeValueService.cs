using Busniss_Logic.GenericRepository;
using InventoryDataAccess.Context;
using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Busniss_Logic.SpecificRepository
{
   public class AttributeValueService:IAttributeValueService
    {
        private readonly IGeneric<AttributeValue> generic;
        private readonly InvintoryContext context;

        public AttributeValueService(IGeneric<AttributeValue> _generic,InvintoryContext _context)
        {
            generic = _generic;
            context = _context;
        }

        public List<AttributeValue> liSize()
        {
            List<AttributeValue> lisize = context.attributevalues.Where(a => a.attribute_id == 1).ToList();
            return lisize;
        }
        public List<AttributeValue> liColor()
        {
            List<AttributeValue> licolor = context.attributevalues.Where(a => a.attribute_id == 2 ).ToList();
            return licolor;
        }

        public List<AttributeValue> liAttributeValues()
        {
            return generic.loadall();
        }
        public List<AttributeValue> Loadall(int id)
        {
            List<AttributeValue> liattributeValues =
                context.attributevalues.Where(a => a.attribute_id == id).ToList<AttributeValue>();
            return liattributeValues;
        }
      
        public void insert(AttributeValue attributevalue)
        {
            generic.insert(attributevalue);
        }
        public void update(AttributeValue attributevalue)
        {
            generic.update(attributevalue);
        }
        public void delete(int id)
        {
            generic.delete(id);
        }
        public List<AttributeValue> search(string name)
        {
            return context.attributevalues.Where(a => a.Name == name).ToList();
        }
        public AttributeValue edit(int id)
        {
           return generic.edit(id);
        }
    }
}
