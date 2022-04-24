using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entities
{
    [Table("AttributeValue")]
   public class AttributeValue
    {
        public int Id { get; set; }

        public string Name { get; set; }
        [ForeignKey("attribute")]
        public int attribute_id { get; set; }
        public Attributes attribute { get; set; }

        [InverseProperty("Size")]
        public List<Product> liproductSize { set; get; }
        [InverseProperty("Color")]
        public List<Product> liproductColor { set; get; }

    }
}
