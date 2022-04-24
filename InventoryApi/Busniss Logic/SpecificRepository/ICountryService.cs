using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busniss_Logic.SpecificRepository
{
   public interface ICountryService
    {
        List<Country> loadall();


    }
}
