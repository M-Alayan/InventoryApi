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
    public class StoreController : ControllerBase
    {
      private readonly  IStoreService storeservice;
        public StoreController(IStoreService _storeservice)
        {
            storeservice = _storeservice;
        }
        [HttpPost]
        [ActionName("insertStore")]
        public IActionResult insertStore(Store store)
        {

            if (store != null)
            {
                storeservice.insert(store);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [ActionName("updateStore")]
        public IActionResult updateStore(Store store)
        {
            if (store != null)
            {
                storeservice.update(store);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [ActionName("deleteStore")]
        public IActionResult deleteStore(int id)
        {
            if (id != 0)
            {
                storeservice.delete(id);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [ActionName("liStore")]
        public List<Store> liStore()
        {
            return storeservice.listore();
        }
        [HttpGet]
        [ActionName("liActiveStore")]
        public List<Store> liActiveStore()
        {
            return storeservice.liActiveStore();
        }
        [HttpGet]
        [ActionName("edit")]
        public Store edit(int id)
        {
            return storeservice.edit(id);
        }
        [HttpGet]
        [ActionName("search")]
        public List<Store> search(string name)
        {
         return storeservice.search(name);
        }
    }
}
