using TeacherService.Models;

namespace TeacherService.Repositories.Interfaces
{
  public interface ITeacherRepository
  {
    bool Create(Teacher teacher);
    Teacher GetTeacher(int id);
    List<Teacher> GetAll();
    bool Update(int id, Teacher teacher);
    bool Delete(int id);
  }
}
