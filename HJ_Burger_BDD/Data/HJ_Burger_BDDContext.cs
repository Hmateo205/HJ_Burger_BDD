using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HJ_Burger_BDD.Models;

namespace HJ_Burger_BDD.Data
{
    public class HJ_Burger_BDDContext : DbContext
    {
        public HJ_Burger_BDDContext (DbContextOptions<HJ_Burger_BDDContext> options)
            : base(options)
        {
        }

        public DbSet<HJ_Burger_BDD.Models.Burger> Burger { get; set; } = default!;
    }
}
