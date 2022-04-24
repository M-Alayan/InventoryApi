using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InventoryDataAccess.Dto
{
    public class RoleModel
    {
        [Required]
        public string Name { get; set; }
    }
}
