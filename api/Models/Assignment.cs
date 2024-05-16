using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

[Table("Assignments")]
public class Assignment
{
     public int Id { get; set; }
    
    [Required]
    public  string Name { get; set; }

    public string Description { get; set; }
    
    public int CourseId { get; set; }
    
    public int CategoryId { get; set; }

    // Navigation Properties -- Creates Relationship in DB

    public virtual Course Course { get; set; }

    public virtual Category Category { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new HashSet<Grade>();
}