using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
	public class Product
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public Decimal Price { get; set; }
	}
	
	public class  productContext:DbContext
	{

		public productContext(DbContextOptions options) : base(options)
		{

		}
		public DbSet<Product> products { get; set; }
	}

}
