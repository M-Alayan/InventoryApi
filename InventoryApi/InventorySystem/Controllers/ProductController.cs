using Busniss_Logic.SpecificRepository;
using InventoryDataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace InventorySystem.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
  [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        
        IConfiguration config;
        public ProductController(IProductService productService, IConfiguration _config)
        {
            this.productService = productService;
         
            config = _config;
        }

        [HttpPost]
        [ActionName("insertProduct")]
        public IActionResult insert(Product product)
        {

            if (product != null)
            {
                //product.Path = product.FilePath;
                productService.insert(product);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [ActionName("updateProduct")]
        public IActionResult update(Product product)
        {
            if (product != null)
            {
                productService.update(product);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [ActionName("deleteProduct")]
        public IActionResult delete(int id)
        {
            if (id != 0)
            {
                productService.delete(id);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [ActionName("liProduct")]
        public List<Product> liProduct()
        {
            return productService.loadAll();
        }
        [HttpGet]
        [ActionName("liActiveProduct")]
        public List<Product> liActiveProduct()
        {
            return productService.liActiveProduct();
        }
        [HttpGet]
        [ActionName("edit")]
        public Product edit(int id)
        {
            return productService.edit(id);
        }
        [HttpGet]
        [ActionName("search")]
        public List<Product> search(string name)
        {
            return productService.search(name);
        }

        [HttpPost]
        [AllowAnonymous]
        [ActionName("uploadFile")]
        public IActionResult uploadFile()
        {
            try
            {
                IFormFile file = HttpContext.Request.Form.Files[0];
                
                string FilePath = Path.Combine(Directory.GetCurrentDirectory(),config["FilePath"],file.FileName);
               
                file.CopyTo(new FileStream(FilePath, FileMode.Create));
                //return Ok(JsonSerializer.Serialize(FilePath));
               
                
               return Ok(JsonSerializer.Serialize(file.FileName));
                //var path = _environment.WebRootPath;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
