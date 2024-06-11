using System;
using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Data
{
	public class AppplicationDbContext : DbContext
	{
		public AppplicationDbContext(DbContextOptions<AppplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CId = 1, Name = "Action", DisplayOrder = 1 },
                new Category { CId = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { CId = 3, Name = "Horror", DisplayOrder = 3 }
                );
        }
    }
}

