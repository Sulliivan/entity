using System.Collections.Generic;
using System.Linq;
using entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace entity.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
      //  private static User student = new User();
      private static List<User> students = new List<User> 
      {
          new User(),
          new User {Id = 1, Name = "Christopher"}
      };

    [HttpGet("AllStudents")]
        public IActionResult Get()
        {
            return Ok(students);
        }
    [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(students.FirstOrDefault(c => c.Id == id));
        }
    [HttpPost]
        public IActionResult AddStudents(User NewUser)
        {
            students.Add(NewUser);
            return Ok(students);
        }
    
    }
}