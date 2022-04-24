using Busniss_Logic.GenericRepository;
using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busniss_Logic.SpecificRepository
{
    public class CountryService:ICountryService
    {
        IGeneric<Country> generic;

        public CountryService(IGeneric<Country> _generic)
        {
            generic = _generic;
        }

        public List<Country> loadall()
        {
            return generic.loadall();
        }
    }
}
