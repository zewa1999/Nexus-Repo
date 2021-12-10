using Microsoft.EntityFrameworkCore;
using NexusBenefit.DomainLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace NexusBenefit.DataLayer
{
    public class NexusBenefitsContext : DbContext
    {
        public DbSet<Benefit> Benefit { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:nexusbenefitssqlserver.database.windows.net,1433;Initial Catalog=NexusBenefits;Persist Security Info=False;User ID=adminbenefits;Password=parola123@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}