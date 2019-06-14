using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace todoapivstemplate.Controllers
{
    public class User
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        static List<User> users = new List<User>{
            new User(){Id=1, firstName="Fred",lastName="Belotte"},
            new User(){Id=2, firstName="Nick",lastName="Excalona"},
        };

        // GET api/values
        [HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        public IActionResult Get()
        {
            //return NotFound();
            return Ok(users);
            // return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        // public ActionResult<string> Get(int id)
        public IActionResult Get(int id)
        {
            var user = users.Where<User>(a => a.Id == id);
            if (id != 0 || User != null)
            {
                return Ok(user);
            }
            else
                return NotFound();
            //return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] User user)
        {

            users.Add(user);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
