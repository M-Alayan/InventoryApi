using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entities
{
    [Table("Order")]
   public class Order
    {
        public int Id { get; set; }
        public string Customer_name { get; set; }
        public string Customer_address { get; set; }
        public string Customer_phone { get; set; }
        [ForeignKey("product")]
        public int product_id { get; set; }
        public Product product { get; set; }
        public double Amount { get; set; }
        public double Gross_amount { get; set; }
        public int Rate { get; set; }
        public int Quantity { get; set; }
        public double Vat { get; set; }
        public double? Descount { get; set; }
        public double Net_amount { get; set; }
        
    }
}
