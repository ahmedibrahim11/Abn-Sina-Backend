using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbnsinaiPharma.Entities
{
	public class Context : DbContext
	{

		public Context(DbContextOptions options) : base(options)
		{


		}
		public virtual DbSet<SalesAndStock> SalesAndStocks { get; set; }
		public virtual  DbSet<SalesByBrick> SalesByBricks { get; set; }
		public virtual DbSet<SalesByClient> SalesByClients { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SalesAndStock>().HasKey(s => s.Id);
			modelBuilder.Entity<SalesByBrick>().HasKey(s => s.Id);
			modelBuilder.Entity<SalesByClient>().HasKey(s => s.Id);
			base.OnModelCreating(modelBuilder);
		}

			
	}
}
