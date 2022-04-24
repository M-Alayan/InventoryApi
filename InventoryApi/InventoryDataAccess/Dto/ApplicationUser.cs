using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryDataAccess.Dto
{
  public  class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }
    }
}
