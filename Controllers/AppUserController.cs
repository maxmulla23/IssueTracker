using System;
using System.Linq;
using IssueTracker.Data;
using IssueTracker.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        public readonly IssueTrackerContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserController(UserManager<User> userManager, SignInManager<User> signInManager, IssueTrackerContext context)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            var result = await _userManager.CreateAsync(user, user.PasswordHash);
            
            if (result.Succeeded)
            {
                return CreatedAtAction("GetUser", new { id = user.Id}, user);
            }
            else 
            {
                return BadRequest(result.Errors);
            }
        }

        
    }
}