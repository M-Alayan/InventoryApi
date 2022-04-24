using Busniss_Logic.GenericRepository;
using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busniss_Logic.SpecificRepository
{
   public class CompanyService:ICompanyService
    {
       private readonly IGeneric<Company> generic;
        public CompanyService(IGeneric<Company> _generic)
        {
            generic = _generic;
        }
        
        public void insert(Company company)
        {
            generic.insert(company);
        }
    }
}
