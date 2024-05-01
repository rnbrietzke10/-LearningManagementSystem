using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

[Table("Schools")]
public class School
{
     public int Id { get; set; }
    
    [Required]
    public  string Name { get; set; }
    
    [Required] 
    public string Address { get; set; }

    [Required]
    public string PhoneNumber { get; set; }



    
    public int DistrictId { get; set; }

    // Navigation Properties -- Creates Relatioship in DB

    public virtual District District { get; set; }

    // public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    
}