using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busniss_Logic.SpecificRepository
{
   public interface IOrderService
    {
        void insert(Order order);

        void delete(int id);
        void update(Order order);
        List<Order> librand();
        Order edit(int id);
        List<Order> liorder();
        List<Order> search(string name);
    }
}
