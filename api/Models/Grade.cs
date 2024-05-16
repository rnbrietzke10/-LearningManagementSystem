using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;


[Table("Grades")]
public class Grade
{
    public int Id { get; set; }
    
    [Required]
    public decimal Score { get; set; }
    
    [Required]
    public int StudentId { get; set; }

    [Required]
    public int AssignmentId { get; set; }
    
    // Navigation Properties -- Creates Relatioship in DB

    public virtual Student Student { get; set; }

    public virtual Assignment Assignment { get; set; }

}