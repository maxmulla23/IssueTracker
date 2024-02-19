using System;
using System.Linq;
using IssueTracker.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        public readonly IssueTrackerContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UserController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IssueTrackerContext context)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
    }
}