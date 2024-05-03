using api.Data;
using api.DTOs;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

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
    public async Task<ActionResult<List<SchoolDto>>> GetAllSchoolsByDistrict(int districtId)
    {

        District district = await _context.Districts.Include(d => d.Schools).FirstOrDefaultAsync(d => d.Id ==districtId);
        if (district == null) return NotFound();
         List<SchoolDto> schoolDtos = district.Schools.Select(s => new SchoolDto()
         {
             Id = s.Id,
             Name = s.Name,
             Address = s.Address,
             PhoneNumber = s.PhoneNumber,
             DistrictName = s.District.Name
         }).ToList();


         return schoolDtos;

    }
        
        
    [HttpPost]
    public async Task<ActionResult<SchoolDto>> CreateSchool(School school)
    {
   
        // TODO: Check to see if school exist in district before adding
        try
        {
          await _context.Schools.AddAsync(school);
            
        }
        catch (Exception e)
        {
            Console.WriteLine("Unable to create school: {0}", e);
        }

        District district = await _context.Districts.FindAsync(school.DistrictId);
        var result = await _context.SaveChangesAsync() > 0; 
        if (!result) return BadRequest("Could not save changes to the DB");
        
        return CreatedAtAction(nameof(CreateSchool),
            new SchoolDto(){ Id=school.Id, Name = school.Name, Address = school.Address, PhoneNumber = school.PhoneNumber, DistrictName = district.Name});
      
    }
}