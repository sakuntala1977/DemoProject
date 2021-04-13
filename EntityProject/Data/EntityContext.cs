using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.Models
{
	class EntityContext :DbContext
	{
		public DbSet<Customer> customers {get;set;}
		public DbSet<Product> orders {get;set;}
		

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=EntityProject");
		}
	}
}
