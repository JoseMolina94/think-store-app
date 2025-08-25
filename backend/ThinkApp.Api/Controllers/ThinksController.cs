using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThinkApp.Api.Data;
using ThinkApp.Api.Models;

namespace ThinkApp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ThinksController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ThinksController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Thinks
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Think>>> GetThinks()
    {
        return await _context.Thinks.ToListAsync();
    }

    // GET: api/Thinks/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Think>> GetThink(int id)
    {
        var think = await _context.Thinks.FindAsync(id);

        if (think == null)
        {
            return NotFound();
        }

        return think;
    }

    // POST: api/Thinks
    [HttpPost]
    public async Task<ActionResult<Think>> PostThink(Think think)
    {
        think.CreatedAt = DateTime.UtcNow;
        _context.Thinks.Add(think);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetThink), new { id = think.Id }, think);
    }

    // PUT: api/Thinks/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutThink(int id, Think think)
    {
        if (id != think.Id)
        {
            return BadRequest();
        }

        _context.Entry(think).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ThinkExists(id))
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

    // DELETE: api/Thinks/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteThink(int id)
    {
        var think = await _context.Thinks.FindAsync(id);
        if (think == null)
        {
            return NotFound();
        }

        _context.Thinks.Remove(think);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool ThinkExists(int id)
    {
        return _context.Thinks.Any(e => e.Id == id);
    }
} 