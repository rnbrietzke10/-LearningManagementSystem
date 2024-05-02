using api.Data;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers;


    
    [ApiController]
    [Route("api/districts")]
    public class DistrictController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DistrictController(ApplicationDbContext context)
        {
            _context = context;
        }
    
        
        [HttpGet]
        public async Task<ActionResult<List<District>>> GetAllDistricts()
        {

            List<District> districts = await _context.Districts.ToListAsync();

            return Ok(districts);
        }
        
        
        [HttpPost]
        public async Task<ActionResult<District>> CreateDistrict(District district)
        {

            try
            {
                await _context.Districts.AddAsync(district);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to create district: {0}", e);
            }
           
            var result = await _context.SaveChangesAsync() > 0;
            
            if (!result) return BadRequest("Could not save changes to the DB");

            return CreatedAtAction(nameof(CreateDistrict),
                new { district.Id }, district);
        }
}