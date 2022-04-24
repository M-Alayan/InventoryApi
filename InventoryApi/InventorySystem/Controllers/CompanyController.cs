using Busniss_Logic.SpecificRepository;
using InventoryDataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystem.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class CompanyController : ControllerBase
    {
        ICountryService countryService;
        ICurancyService curancyService;
        ICompanyService companyService;
        public CompanyController(ICountryService _countryService, ICurancyService _curancyService, ICompanyService _companyService)
        {
            companyService = _companyService;
            curancyService = _curancyService;
            countryService = _countryService;
        }

        [HttpPost]
        [ActionName("insertCompany")]
        public void insertCompany(Company company)
        {
            companyService.insert(company);
        }

        [HttpGet]
        [ActionName("loadAllCountry")]
        public List<Country> loadAllCountry()
        {
            return countryService.loadall();
        }

        [HttpGet]
        [ActionName("loadAllCurancy")]
        public List<Curancy> loadAllCurancy()
        {
            return curancyService.loadall();
        }
    }
}
