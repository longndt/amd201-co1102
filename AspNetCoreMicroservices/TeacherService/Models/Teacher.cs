using System.ComponentModel.DataAnnotations;

namespace TeacherService.Models
{
  public class Teacher
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public string Email { get; set; }
  }
}
