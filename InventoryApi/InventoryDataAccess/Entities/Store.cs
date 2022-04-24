﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entities
{
    [Table("Store")]
   public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int status { get; set;  }
        public List<Product> liproduct { set; get; }
    }
}
