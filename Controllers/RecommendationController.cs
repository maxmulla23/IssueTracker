using System;
using System.Linq;
using IssueTracker.Data;
using Microsoft.AspNetCore.Mvc;
using IssueTracker.Models;
using Microsoft.EntityFrameworkCore;


namespace IssueTracker.Controllers
{
    [Route("api/[controller]")]
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
            try
            {
              _context.Recommendations.Add(recommendation);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRecommendation), new { id = recommendation.Id}, recommendation);  
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
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

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecommendation(int id, Recommendation recommendation)
        {
            if(id != recommendation.Id)
            {
                return BadRequest();
            }
            _context.Entry(recommendation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if(!RecommendationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                } 
            }
            return NoContent();

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecommendation(int id)
        {
            var recommendation = await _context.Recommendations.FindAsync(id);
            if (recommendation == null)
            {
                return NotFound();
            }

            _context.Recommendations.Remove(recommendation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RecommendationExists(int id)
        {
            return _context.Recommendations.Any(e => e.Id == id);
        }
    }
}