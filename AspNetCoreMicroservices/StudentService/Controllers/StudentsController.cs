using Microsoft.AspNetCore.Mvc;

using StudentService.Models;
using StudentService.Repositories.Interfaces;

namespace StudentService.Controllers
{
  [ApiController]
  public class StudentsController : ControllerBase
  {
    private readonly IStudentRepository _studentRepository;
    public StudentsController(IStudentRepository studentRepository)
    {
      _studentRepository = studentRepository;
    }

    [HttpGet("/api/students/all")]
    public IActionResult Get()
    {
      var students = _studentRepository.GetAll();
      return Ok(students);
    }

    [HttpGet("/api/students/{id}")]
    public IActionResult Get(int id)
    {
      var student = _studentRepository.GetStudent(id);
      if (student == null)
      {
        return NotFound();
      }
      return Ok(student);
    }

    [HttpPost("/api/students/create")]
    public IActionResult Create([FromBody] Student student)
    {
      var result = _studentRepository.Create(student);
      if (result)
      {
        return Ok("Created Successfully");
      }
      return BadRequest();
    }

    [HttpPut("/api/students/{id}")]
    public IActionResult Update(int id, [FromBody] Student student)
    {
      var result = _studentRepository.Update(id, student);
      if (result)
      {
        return Ok("Updated Sucessfully");
      }
      return BadRequest();
    }

    [HttpDelete("/api/students/{id}")]
    public IActionResult Delete(int id)
    {
      var result = _studentRepository.Delete(id);
      if (result)
      {
        return Ok("Delete Successfully");
      }
      return BadRequest();
    }
  }
}
