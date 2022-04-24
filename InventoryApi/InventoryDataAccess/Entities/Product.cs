using System;
using System.Collections.Generic;
using System.Text;
//using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDataAccess.Entities
{
    [Table("Product")]
    public  class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int Sku { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        [ForeignKey("Color")]
        public int Color_id { get; set; }
        public AttributeValue Color { get; set; }
        [ForeignKey("Size")]
        public int Size_id { get; set; }
        public AttributeValue Size { get; set; }

        [ForeignKey("brand")]
        public int Brand_id { get; set; }
        public Brand brand { get; set; }
        [ForeignKey("category")]
        public int Category_id { get; set; }
        public Category category { get; set; }
        [ForeignKey("store")]
        public int Store_id { get; set; }
        public Store store { get; set; }
        public int Availabilty { get; set; }

    }
}
