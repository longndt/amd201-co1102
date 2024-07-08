using TeacherService.Data;
using TeacherService.Models;
using TeacherService.Repositories.Interfaces;

namespace TeacherService.Repositories
{
  public class TeacherRepository : ITeacherRepository
  {
    private ApplicationDbContext _context;
    public TeacherRepository(ApplicationDbContext context)
    {
      _context = context;
    }
    public bool Create(Teacher teacher)
    {
      try
      {
        _context.Teachers.Add(teacher);
        _context.SaveChanges();
        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }

    public bool Delete(int id)
    {
      try
      {
        var student = _context.Teachers.SingleOrDefault(t => t.Id == id);
        if (student == null)
        {
          return false;
        }
        _context.Teachers.Remove(student);
        _context.SaveChanges();
        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }

    public List<Teacher> GetAll()
    {
      return _context.Teachers.ToList();
    }

    public Teacher GetTeacher(int id)
    {
      try
      {
        var teacher = _context.Teachers.SingleOrDefault(t => t.Id == id);
        return teacher;
      }
      catch (Exception)
      {
        return null;
      }
    }

    public bool Update(int id, Teacher teacher)
    {
      try
      {
        var existingTeacher = GetTeacher(id);
        if (existingTeacher == null)
        {
          return false;
        }
        existingTeacher.Name = teacher.Name;
        existingTeacher.Email = teacher.Email;
        existingTeacher.Department = teacher.Department;
        _context.SaveChanges();
        return true;

      }
      catch (Exception)
      {
        return false;
        throw;
      }
    }
  }
}
