using CommonEmployeeAPI.CommonEmployeeApi.Database;
using CommonEmployeeAPI.Interfaces;
using CommonEmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;

namespace CommonEmployeeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly CommonEmployeeDbContext _commonEmployeeAPIContext;
        private readonly IUserInterface _userInterface;

        public UserController(CommonEmployeeDbContext commonEmployeeAPIContext, IUserInterface userInterface)
        {
            this._commonEmployeeAPIContext = commonEmployeeAPIContext;
            this._userInterface = userInterface;
        }

        //Get All Employee
        [HttpGet]
        public IEnumerable<Users> GetUserList()
        {
            return this._userInterface.ListUsers().ToList();
        }

        // GET: api/Employees/5
        [HttpGet("{id}")]
        public ActionResult<Users> OpenUser(int id)
        {
            var userObject = this._userInterface.GetUsers(id);

            if (userObject == null)
            {
                return NotFound();
            }
            return userObject;
        }

        // PUT: api/Employees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [ResponseType(typeof(Users))]
        public IActionResult UpdateUsers(int id, Users usermodel)
        {
            if (id != usermodel.Id)
            {
                return BadRequest();
            }


            try
            {
                this._userInterface.UpdateUsers(usermodel);
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        // POST: api/Employees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

        [HttpPost]
        public ActionResult<Users> PostEmployee(Users usermodel)
        {
            this._userInterface.SaveUsers(usermodel);
            return CreatedAtAction("OpenUser", new { id = usermodel.Id }, usermodel);
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var userObject = this._userInterface.GetUsers(id);
            if (userObject == null)
            {
                return NotFound();
            }
            this._userInterface.DeletUsers(id);

            return Ok();
        }

        private bool UserExists(int id)
        {
            return this._userInterface.IsUsersExists(id);
        }
    }
}
