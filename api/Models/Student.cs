using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

[Table("Students")]
public class Student
{
    public int Id { get; set; }
    
    [Required]
    public  string FirstName { get; set; }

    [Required]
    public  string LastName { get; set; }
    
    [Required]
    public string Email { get; set; }
    
    [Required] 
    public string Address { get; set; }

    public string PhoneNumber { get; set; }

    [NotMapped]
    public string? FullName { get { return $"{FirstName} {LastName}"; } }

    
    public int SchoolId { get; set; }

    // Navigation Properties -- Creates Relatioship in DB

    public virtual School School { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
}