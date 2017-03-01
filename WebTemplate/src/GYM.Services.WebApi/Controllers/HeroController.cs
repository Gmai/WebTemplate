using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GYM.Services.WebApi.Controllers
{
    public class HeroController : ApiController
    {
        // GET: api/Hero
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Hero/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Hero
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Hero/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Hero/5
        public void Delete(int id)
        {
        }
    }
}
