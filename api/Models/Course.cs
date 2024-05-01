using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

[Table("Courses")]
public class Course
{
     public int Id { get; set; }
    
    [Required]
    public  string Name { get; set; }

    [Required]
    public  string CourseCode { get; set; }
    
    
    public int SchoolId { get; set; }

    // Navigation Properties -- Creates Relationship in DB

    public virtual School School { get; set; }

     public virtual ICollection<Assignment> Assignments { get; set; } = new HashSet<Assignment>();
    
}