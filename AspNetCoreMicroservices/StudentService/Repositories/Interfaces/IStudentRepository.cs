using StudentService.Models;

namespace StudentService.Repositories.Interfaces
{
  public interface IStudentRepository
  {
    bool Create(Student student);
    Student GetStudent(int id);
    List<Student> GetAll();
    bool Update(int id, Student student);
    bool Delete(int id);
  }
}
