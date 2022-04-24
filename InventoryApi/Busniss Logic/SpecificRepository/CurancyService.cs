using Busniss_Logic.GenericRepository;
using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busniss_Logic.SpecificRepository
{
    public class CurancyService:ICurancyService
    {
        IGeneric<Curancy> generic;
        public CurancyService(IGeneric<Curancy> _generic)
        {
            generic = _generic;
        }

        public List<Curancy> loadall()
        {
          return  generic.loadall();
        }
    }
}
