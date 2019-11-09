using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightingApp.Data.Models
{
    public class LightingContext : DbContext
    {
        public DbSet<Lighting> Lightings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=lighting.db");
    }
}
