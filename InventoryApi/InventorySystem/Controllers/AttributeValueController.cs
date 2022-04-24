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
    public class AttributeValueController : ControllerBase
    {
        private readonly IAttributeValueService attributeValueService;

        public AttributeValueController(IAttributeValueService _attributeValueService)
        {
            attributeValueService = _attributeValueService;
        }


        [HttpGet]
        [ActionName("liSize")]
        public List<AttributeValue> liSize()
        {
            return attributeValueService.liSize();
        }
        [HttpGet]
        [ActionName("liColor")]
        public List<AttributeValue> liColor()
        {
            return attributeValueService.liColor();
        }

        [HttpPost]
        [ActionName("insertAttributeValue")]
        public IActionResult insert(AttributeValue attrval)
        {
            if (attrval != null)
            {
                attributeValueService.insert(attrval);
                return Ok();
            }
            else
            {  return BadRequest();
            }}
        [HttpPost]
        [ActionName("updateAttributeValue")]
        public IActionResult update(AttributeValue attrval)
        {
            if (attrval != null)
            {
                attributeValueService.update(attrval);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [ActionName("deleteAttributeValue")]
        public IActionResult delete(int id)
        {
            if (id != 0)
            {
                attributeValueService.delete(id);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [ActionName("liAttributeValue")]
        public List<AttributeValue> liAttributeValue()
        {
            return attributeValueService.liAttributeValues();

        }
            [HttpGet]
        [ActionName("edit")]
        public AttributeValue edit(int id)
        {
            return attributeValueService.edit(id);
        }

        [HttpGet]
        [ActionName("search")]
        public List<AttributeValue> search(string name)
        {
            return attributeValueService.search(name);
        }
        [HttpGet]
        [ActionName("loadAll")]
        public List<AttributeValue> LoadAll(int id)
        {
            List<AttributeValue> liattributeValues = attributeValueService.Loadall(id);
            return liattributeValues;
        }
     

    }
}



