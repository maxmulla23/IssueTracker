using System;
using System.Linq;
using IssueTracker.Data;
using IssueTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker.Controllers
{
    [Route("api/controller")]
    [ApiController]

    public class FeedbackController : ControllerBase
    {
        public readonly IssueTrackerContext _context;

        public FeedbackController(IssueTrackerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Feedback>>> GetFeedback()
        {
            return await _context.Feedbacks.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Feedback>> GetFeedback(int id)
        {
            var feedback = await _context.Feedbacks.FindAsync(id);

            if(feedback == null)
            {
                return NotFound();
            }
            return feedback;
        }
    }
}