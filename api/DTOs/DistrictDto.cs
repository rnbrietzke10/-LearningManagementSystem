

namespace api.DTOs;

public class DistrictDto
{
    public int Id { get; set; }
    public  string Name { get; set; }
    public  List<SchoolDto> Schools { get; set; }
}