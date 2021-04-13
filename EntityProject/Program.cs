using EntityProject.Models;
using System;
using System.Linq;

namespace EntityProject
{
	class Program
	{
		static void Main(string[] args)
		{
			using EntityContext context= new EntityContext();
			//Product p = new Product()
			//{
			//	Name = "Entity1",
			//	Price = 11
			//};
			//context.orders.Add(p);
			//Product p1 = new Product()
			//{
			//	Name = "Entity3",
			//	Price = 12
			//};
			//context.Add(p1);
			//context.SaveChanges();
			//Console.Read();
			var entity= context.orders.Where(p=>p.Name=="Entity1").FirstOrDefault();
			if(entity is Product)
			{
				//entity.Price=12;
				//context.SaveChanges();
				context.Remove(entity);
				context.SaveChanges();
			}


			var products = context.orders.Where(p => p.Price ==12).OrderBy(p=>p.Name);
			foreach (var item in products)
			{
				Console.WriteLine(item.Name);
				Console.WriteLine(item.Price);
			}
				          
		}

		
	}
}
