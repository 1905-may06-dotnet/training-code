using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("contact/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        static List<User> users = new List<User>() {
            new User(){ Id=1, firstName="Fred",lastName="B", phone="123456584798"},
            new User(){ Id=2, firstName="Seal",lastName="Fred", phone="7896456456"},
            new User(){ Id=3, firstName="Evan",lastName="something", phone="5489763213"},
            new User(){ Id=4, firstName="John",lastName="M", phone="546586465"},
            new User(){ Id=5, firstName="Nick",lastName="Escalona", phone="23465894"}
        };
        // GET api/values
        [HttpGet]
        [ProducesResponseType(typeof(User),StatusCodes.Status200OK)]
        //public ActionResult<IEnumerable<string>> Get()
        public ActionResult<IEnumerable<User>> Get()
        {
            //return Ok(users);
            return users;
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(User), StatusCodes.Status404NotFound)]
        public ActionResult<User> Get(int id)
        {
            var user = users.Where<User>(i => i.Id == id).FirstOrDefault();
            if (user != null)
                return user;
            else
                return NotFound();
        }
        /// <summary>
        /// This Action is used to add a user in the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        // POST api/values
        [HttpPost]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<User>> Post([FromBody] User user)
        {
            //User user1 = new User() { Id = 6, firstName = "Cameron", lastName = "Coley", phone = "75458486" };
            users.Add(user);
            // return Accepted();
            return users;

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
