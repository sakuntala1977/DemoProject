using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApI.Controllers
{
	public class ValueController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
