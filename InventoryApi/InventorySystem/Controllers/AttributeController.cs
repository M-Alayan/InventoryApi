using Busniss_Logic.SpecificRepository;
using InventoryDataAccess.Dto;
using InventoryDataAccess.Entities;
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
    public class AttributeController : ControllerBase
    {
        private readonly IAttributeService attributeService;

        public AttributeController(IAttributeService attributeService)
        {
            this.attributeService = attributeService;
        }

    
        [HttpGet]
        [ActionName("LoadData")]
        public List<VmAttribute> loadDataa()
        {
            return attributeService.LoadData();
        }

    }
}
