using Busniss_Logic.GenericRepository;
using InventoryDataAccess.Context;
using InventoryDataAccess.Dto;
using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Busniss_Logic.SpecificRepository
{
   public class AttributeService:IAttributeService
    {
        private readonly IGeneric<Attributes> generic;
        private readonly InvintoryContext context;
        public AttributeService(IGeneric<Attributes> _generic ,InvintoryContext _context)
        {
            generic = _generic;
            context = _context;
        }

        public List<VmAttribute> LoadData()
        {
            List<VmAttribute> li = context.attribute.Select(data=>
            new VmAttribute()
            {
                attributes = data,
                Count = data.liattributevalue.Count()
            }
            ).ToList();
            return li;
        }
    



    }
}
