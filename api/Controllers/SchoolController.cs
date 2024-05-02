using api.Data;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers;

[ApiController]
[Route("api/schools")]
public class SchoolController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public SchoolController(ApplicationDbContext context)
    {
        _context = context;
    }
    
        
    [HttpGet("{districtId}")]
    
    public async Task<ActionResult<List<School>>> GetAllSchoolsByDistrict(int districtId)
    {

        List<School> schools = await _context.Schools.Include(s => s.District).Where(s => s.DistrictId == districtId).ToListAsync();
        Console.WriteLine("Schools: {0}", schools);

        return Ok(schools);
    }
        
        
    [HttpPost]
    public async Task<ActionResult<School>> CreateSchool(School school)
    {

        try
        {
            await _context.Schools.AddAsync(school);
        }
        catch (Exception e)
        {
            Console.WriteLine("Unable to create school: {0}", e);
        }
           
        var result = await _context.SaveChangesAsync() > 0;
            
        if (!result) return BadRequest("Could not save changes to the DB");

        return CreatedAtAction(nameof(CreateSchool),
            new { school.Id }, school);
    }
}