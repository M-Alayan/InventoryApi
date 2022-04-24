using Busniss_Logic.SpecificRepository;
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
    public class OrderController : ControllerBase
    {
        IOrderService orderservice;
        public OrderController(IOrderService _orderservice)
        {
            orderservice = _orderservice;
        }

        [HttpPost]
        [ActionName("insertOrder")]
        public IActionResult insert(Order order)
        {

            if (order != null)
            {
                orderservice.insert(order);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [ActionName("updateOrder")]
        public IActionResult update(Order order)
        {
            if (order != null)
            {
                orderservice.update(order);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [ActionName("deleteOrder")]
        public IActionResult delete(int id)
        {
            if (id != 0)
            {
                orderservice.delete(id);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [ActionName("liOrder")]
        public List<Order> liOrder()
        {
            return orderservice.liorder();

        }

        [HttpGet]
        [ActionName("edit")]
        public Order edit(int id)
        {
            return orderservice.edit(id);
        }

        [HttpGet]
        [ActionName("search")]
        public List<Order> search(string name)
        {
            return orderservice.search(name);
        }
    }
}
