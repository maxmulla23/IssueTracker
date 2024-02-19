using System;
using System.Linq;
using IssueTracker.Data;
using Microsoft.AspNetCore.Mvc;
using IssueTracker.Models;
using Microsoft.EntityFrameworkCore;


namespace IssueTracker.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class RecommendationsController : ControllerBase
    {
        public readonly IssueTrackerContext _context;

        public RecommendationsController(IssueTrackerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recommendation>>> GetRecommendation()
        {
            return await _context.Recommendations.ToListAsync();

        }

        [HttpPost]
        public async Task<ActionResult<Recommendation>> PostRecommendation(Recommendation recommendation)
        {
            _context.Recommendations.Add(recommendation);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRecommendation), new { id = recommendation.Id}, recommendation);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Recommendation>> GetRecommendation(int id)
        {
            var recommendation = await _context.Recommendations.FindAsync(id);

            if (recommendation == null)
            {
                return NotFound();
            }

            return recommendation;
        }
    }
}