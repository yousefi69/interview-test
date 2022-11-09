using interview.Interface;
using interview.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace interview.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;
        public UserController(IUser user)
        {
            _user = user;
        }
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult GetUserList()
        {
            return Ok( _user.getUserList());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult getUserbyId(int id)
        {
            return Ok(_user.getUserbyId(id));
        }

        // POST api/<UserController>
        [HttpPost]
        public void addUser([FromBody] User value)
        {
            _user.addUser(value);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void updateUser(int id,[FromBody] User value)
        {
            _user.updateUser(value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _user.removeUser(id);
        }
    }
}
