using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		public IEnumerable<string> Get()
		{
			return new string[]  { "a", "b" };
		}

		
	}
}
