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
    }
}

