using AspCore1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCore1.Data
{
	public class  EntityContext : DbContext
	{
		public EntityContext(DbContextOptions options) :base(options)
		{

		}
		public DbSet<Customer> customers { get; set; }
		public DbSet<Product> products { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
		optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=AspCore1");
		}
	} 
}
