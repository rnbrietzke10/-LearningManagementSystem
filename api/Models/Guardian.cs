using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

[Table("Guardians")]
public class Guardian
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
    

    // Navigation Properties -- Creates Relatioship in DB

    public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();


}