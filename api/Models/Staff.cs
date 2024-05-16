using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

[Table("Staff")]
public class Staff
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

    // Navigation Properties -- Creates Relatioship in DB

    public virtual School Company { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
}