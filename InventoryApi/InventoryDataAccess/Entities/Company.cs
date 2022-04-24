using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entities
{
    [Table("Company")]
    public class Company
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        
        public int Vat_charge { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }




        [ForeignKey("country")] 
        public int country_id { get; set; }
        public string Message { get; set; }
        [ForeignKey("curancy")]
        public int currency_id { get; set; }
        public Curancy curancy { get; set; }
        public Country country { get; set; }
    }
}
