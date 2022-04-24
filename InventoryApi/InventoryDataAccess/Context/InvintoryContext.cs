using InventoryDataAccess.Dto;
using InventoryDataAccess.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;


namespace InventoryDataAccess.Context
{
   public class InvintoryContext:IdentityDbContext<ApplicationUser>
    {
        //IConfiguration config;
        //public InvintoryContext(IConfiguration _config)
        //{
        //    config = _config;
        //}
        public InvintoryContext(DbContextOptions<InvintoryContext> options) : base(options)
        {

        }
        public DbSet<AttributeValue> attributevalues {get; set;}
             public DbSet<Attributes> attribute {get; set;}
              public DbSet<Brand>brand{ get; set; }

              public DbSet<Category> category{ get; set; }

               public DbSet<Country> country{ get; set; }

             public DbSet<Curancy>curancy{ get; set; }

                public DbSet<Company>company{ get; set; }
                 public DbSet<Order>order{ get; set; }
                  public DbSet<Store>store{ get; set; }
        public DbSet<Product> product { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(config.GetConnectionString("Invintory"));
        //    base.OnConfiguring(optionsBuilder);
        //}

    }
}
