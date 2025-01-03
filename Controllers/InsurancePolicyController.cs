using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InsurancePolicyAPIBackend.Models;

[Route("api/[controller]")]
[ApiController]
public class InsurancePoliciesController : ControllerBase
{
    private readonly PolicyDbContext _context;

    public InsurancePoliciesController(PolicyDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetPolicies()
    {
        return Ok(await _context.InsurancePolicies.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPolicy(int id)
    {
        var policy = await _context.InsurancePolicies.FindAsync(id);
        if (policy == null) return NotFound();
        return Ok(policy);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePolicy([FromBody] InsurancePolicy policy)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        await _context.InsurancePolicies.AddAsync(policy);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetPolicy), new { id = policy.Id }, policy);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePolicy(int id, [FromBody] InsurancePolicy policy)
    {
        if (id != policy.Id) return BadRequest();
        _context.Entry(policy).State = EntityState.Modified;
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.InsurancePolicies.Any(e => e.Id == id)) return NotFound();
            throw;
        }
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePolicy(int id)
    {
        var policy = await _context.InsurancePolicies.FindAsync(id);
        if (policy == null) return NotFound();
        _context.InsurancePolicies.Remove(policy);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
