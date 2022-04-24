using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busniss_Logic.SpecificRepository
{
   public interface IAttributeValueService
    {

        public List<AttributeValue> liSize();
        public List<AttributeValue> liColor();

        AttributeValue edit(int id);
        List<AttributeValue> search(string name);
        void delete(int id);
         void update(AttributeValue attributevalue);
        void insert(AttributeValue attributevalue);
        List<AttributeValue> liAttributeValues();
        List<AttributeValue> Loadall(int id);
    }
}
