using api.Models;

namespace api.DTOs;

public class SchoolDto
{
    public int Id { get; set; }
    
    public  string Name { get; set; }
    
    public string Address { get; set; }

    public string PhoneNumber { get; set; }

    public  string DistrictName { get; set; }
}