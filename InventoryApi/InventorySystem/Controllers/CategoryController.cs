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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }

        [HttpPost]
        [ActionName("insertCategory")]
        public IActionResult insertCategory(Category cateegory)
        {

            if (cateegory != null)
            {
                categoryService.insert(cateegory);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [ActionName("updateCategory")]
        public IActionResult updateCategory(Category cateegory)
        {
            if (cateegory != null)
            {
                categoryService.update(cateegory);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [ActionName("deleteCategory")]
        public IActionResult deleteCategory(int id)
        {
            if (id != 0)
            {
                categoryService.delete(id);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [ActionName("liCategory")]
        public List<Category> liCategory()
        {
            return categoryService.licategory();
        }
        [HttpGet]
        [ActionName("liActiveCategory")]
        public List<Category> liActiveCategory()
        {
            return categoryService.liActiveCategory();
        }

        [HttpGet]
        [ActionName("edit")]
        public Category edit(int id)
        {
            return categoryService.edit(id);
        }

        [HttpGet]
        [ActionName("search")]
        public List<Category> search(string name)
        {
            return categoryService.search(name);
        }
    }
}
