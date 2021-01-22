using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ClubAsp.Models;

namespace ClubAsp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ClubAsp.Models.GreenBean> GreenBean { get; set; }
        public DbSet<ClubAsp.Models.Product> Product { get; set; }
    }
}
