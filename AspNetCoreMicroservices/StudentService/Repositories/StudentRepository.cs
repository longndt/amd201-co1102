using StudentService.Data;
using StudentService.Models;
using StudentService.Repositories.Interfaces;

namespace StudentService.Repositories
{
  public class StudentRepository : IStudentRepository
  {
    private ApplicationDbContext _context;
    public StudentRepository(ApplicationDbContext context)
    {
      _context = context;
    }


    public bool Create(Student student)
    {
      try
      {
        _context.Students.Add(student);
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
      // Delete student by id
      try
      {
        var student = _context.Students.FirstOrDefault(s => s.Id == id);
        if (student == null)
        {
          return false;
        }
        _context.Students.Remove(student);
        _context.SaveChanges();
        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }

    public List<Student> GetAll()
    {
      return _context.Students.ToList();
    }

    public Student GetStudent(int id)
    {
      try
      {
        var student = _context.Students.FirstOrDefault(s => s.Id == id);
        return student;
      }
      catch (Exception)
      {
        return null;
      }
    }

    public bool Update(int id, Student student)
    {
      try
      {
        var existingStudent = GetStudent(id);
        if (existingStudent == null)
        {
          return false;
        }
        existingStudent.Name = student.Name;
        existingStudent.Email = student.Email;
        existingStudent.Address = student.Address;
        _context.SaveChanges();
        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }
  }
}
