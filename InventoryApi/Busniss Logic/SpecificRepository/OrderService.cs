using Busniss_Logic.GenericRepository;
using InventoryDataAccess.Context;
using InventoryDataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Busniss_Logic.SpecificRepository
{
   public class OrderService:IOrderService
    {
        IGeneric<Order> generic;
        InvintoryContext context;
        public OrderService(IGeneric<Order> _generic ,InvintoryContext _context)
        {
            generic = _generic;
            context = _context;
        }
        public void insert(Order order)
        {
            generic.insert(order);
        }
        public void update(Order order)
        {
            generic.update(order);
        }
        public void delete(int id)
        {
            generic.delete(id);
        }
        public List<Order> librand()
        {
            return generic.loadall();
        }
        public List<Order> liorder()
        {
            List<Order> liorder=context.order.Include("product").ToList();
            return liorder;
        }

        public Order edit(int id)
        {
            return generic.edit(id);
        }
        public List<Order> search(string name)
        {
            List<Order> search = context.order.Where(a => a.Customer_name == name).ToList();
            return search;

        }

    }
}
