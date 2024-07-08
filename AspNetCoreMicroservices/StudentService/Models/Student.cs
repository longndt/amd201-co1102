using System.ComponentModel.DataAnnotations;

namespace StudentService.Models
{
  public class Student
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
  }
}
