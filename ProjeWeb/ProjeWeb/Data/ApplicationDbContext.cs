using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjeWeb.Models;

namespace ProjeWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Kullanici> Kullanici { get; set; }

        public DbSet<Otel> Otel { get; set; }

        public DbSet<Tur> Tur { get; set; }

        public DbSet<Yorum> Yorum { get; set; }

    }
}
