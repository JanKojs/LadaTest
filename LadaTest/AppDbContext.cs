using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadaTest
{
    public class AppDbContext : DbContext
    {
        public DbSet<Skladba> Songs { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql("User ID=postgres;Password=MasterPassword;Host=localhost;Port=5432;Database=LadaTest;");
        }
    }
}
