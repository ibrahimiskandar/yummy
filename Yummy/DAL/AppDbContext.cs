using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yummy.Models;

namespace Yummy.DAL
{
    public class AppDbContext:IdentityDbContext
    {
        private readonly DbContextOptions _options;

        public AppDbContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }

        public DbSet<Food> Foods { get; set; }


    }
}
