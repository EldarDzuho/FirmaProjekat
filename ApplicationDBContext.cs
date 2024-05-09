using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {
            
        }

        public DbSet<BuildingTenant> BuildingTenants { get; set; }
        public DbSet<BuildingAdmin> BuildingAdmins { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}