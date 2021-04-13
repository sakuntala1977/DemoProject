using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI2.Models;

namespace WebAPI2.Controllers
{
    public class peopleController : ApiController
    {
        List<Person> people = new List<Person>();
        public peopleController()
		{
          people.Add(new Person { Id=1,Name="sakku",Age=30});
          people.Add(new Person { Id = 2, Name = "sakku1", Age = 40 });
          people.Add(new Person { Id = 3, Name = "sakku2", Age = 60 });

        }
        // GET: api/people
        public List<Person> Get()
        {
            return people;;
        }

        // GET: api/people/5
        public Person Get(int id)
        {
			return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/people
        public void Post(Person p)
        {
           people.Add(p);
        }

        // PUT: api/people/5
       

        // DELETE: api/people/5
        public void Delete(Person p)
        {
            people.Remove(p);
        }
    }
}
