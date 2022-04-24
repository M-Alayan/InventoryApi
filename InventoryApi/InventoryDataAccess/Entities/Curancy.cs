using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entities
{
    [Table("Curancy")]
    public class Curancy
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<Company> licompany { set; get; }
    }
}
