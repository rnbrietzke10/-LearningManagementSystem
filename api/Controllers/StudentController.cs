using api.Data;
using api.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentController  : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {

            List<Student> students = await _context.Students.ToListAsync();

            return Ok(students);
        }
        
        
        [HttpPost]
        public async Task<ActionResult<Student>> CreateStudent(Student student)
        {

            try
            {
                await _context.Students.AddAsync(student);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to create student",e);
            }
           
            var result = await _context.SaveChangesAsync() > 0;
            
        if (!result) return BadRequest("Could not save changes to the DB");

        return CreatedAtAction(nameof(CreateStudent),
            new { student.Id }, student);
        }
        
    }
}