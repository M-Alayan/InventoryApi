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
    public class BrandController : ControllerBase
    {
        IBrandService brandservice;
        public BrandController(IBrandService _brandservice)
        {
            brandservice = _brandservice;
        }

        [HttpPost]
        [ActionName("insertBrand")]
        public IActionResult insertBrand(Brand brand)
        {
          
                if (brand != null)
                {
                    brandservice.insert(brand);
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
        }
        [HttpPost]
        [ActionName("updateBrand")]
        public IActionResult updateBrand(Brand brand)
        {
            if (brand != null)
            {
                brandservice.update(brand);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [ActionName("deleteBrand")]
        public IActionResult deleteBrand(int id)
        {
            if (id != 0)
            {
                brandservice.delete(id);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [ActionName("liBrand")]
        public List<Brand> librand()
        {
            return brandservice.librand();

        }
        [HttpGet]
        [ActionName("liActiveBrand")]
        public List<Brand> liActiveBrand()
        {
            return brandservice.liActiveBrand();
        }

        [HttpGet]
        [ActionName("edit")]
        public Brand edit(int id)
        {
            return brandservice.edit(id);
        }

        [HttpGet]
        [ActionName("search")]
        public List<Brand> search(string name)
        {
            return brandservice.search(name);
        }
    }
}
