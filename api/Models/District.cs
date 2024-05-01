using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;


[Table("Districts")]
public class District
{
    public int Id { get; set; }
    
    [Required]
    public  string Name { get; set; }


    
   
    // Navigation Properties -- Creates Relatioship in DB


    public virtual ICollection<School> Schools { get; set; } = new HashSet<School>();
}