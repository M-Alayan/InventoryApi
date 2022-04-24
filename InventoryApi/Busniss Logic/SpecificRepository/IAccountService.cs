using InventoryDataAccess.Dto;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Busniss_Logic.SpecificRepository
{
  public interface IAccountService
    {
        Task<IdentityResult> Create(SignUpModel model);
        SignInResult SignIn(SignInModel model);
         Task<IdentityResult> AddRole(RoleModel model);
        List<IdentityRole> GetRole();
        List<string> GetUserRoles(ApplicationUser obj);
        ApplicationUser GetUserByName(string Username);
        Task Signout();
    }
}
