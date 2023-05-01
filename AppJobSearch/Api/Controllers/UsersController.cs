using Api.Database;
using DomainLib.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private JobSearchContext _data;

        public UsersController(JobSearchContext data)
        {
            _data = data;
        }

        [HttpGet]
        public IActionResult GetUser(string email,string password)
        {
            User UserDb =_data.Users.FirstOrDefault(a=>a.Email == email && a.Password == password);

            if(UserDb == null)
            {
                return NotFound();
            }

            return new JsonResult(UserDb);
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _data.Users.Add(user);
            _data.SaveChanges();

            return CreatedAtAction(nameof(GetUser), new { email = user.Email, password = user.Password },user);
        }
    }
}
