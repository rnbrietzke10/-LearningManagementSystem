using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

[Table("Categories")]
public class Category
{
     public int Id { get; set; }
    
    [Required]
    [MaxLength(50)]
    public  string Name { get; set; }
    
    [Required] 
    public decimal Weight { get; set; }

    public int AssignmentId { get; set; }
    
    // Navigation Properties -- Creates Relationship in DB

    public virtual Assignment Assignment { get; set; }
}