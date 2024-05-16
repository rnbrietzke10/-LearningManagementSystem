using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

[Table("Faculty")]
public class Faculty
{
    public int Id { get; set; }
    
    [Required]
    [MaxLength(150)]
    public  string FirstName { get; set; }

    [Required]
    [MaxLength(150)]
    public  string LastName { get; set; }
    
    [Required]
    [MaxLength(350)]
    public string Email { get; set; }
    
    [Required] 
    [MaxLength(350)]
    public string Address { get; set; }
    
    [MaxLength(20)]
    public string PhoneNumber { get; set; }
    
    public int SchoolId { get; set; }
    
    // Navigation Properties -- Creates Relationship in DB

    public virtual School School { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
}