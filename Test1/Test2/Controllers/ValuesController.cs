using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test.Entidades;


namespace Test2.Controllers
{
    //[Authorize]
    [AllowAnonymous]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [HttpPost]
        public IHttpActionResult CreateUser([FromBody] Entidad datos )
        {
            Entidad Info = new Entidad();

            return Ok(Info);
        }

        [HttpDelete]
        public IHttpActionResult DeleteUser(int id)
        {

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult Retrieve([FromUri] Entidad datos)
        {
            var Info = new List<Entidad>();

            return Ok(Info);
        }

        [HttpPut]
        public IHttpActionResult UpdateUser([FromUri] Entidad datos)
        {
            var Info = new Entidad();

            return Ok(Info);
        }

    } 
}
