using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApI.Controllers
{
	[Microsoft.AspNetCore.Mvc.Route("[controller]")]
	[ApiController]
	public class SomeController : ControllerBase
	{
		public IHttpActionResult get()
		{
			return (IHttpActionResult)Ok (new [] {"a","b"});
		}
	}
}
