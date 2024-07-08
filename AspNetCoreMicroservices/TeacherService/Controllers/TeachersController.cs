using Microsoft.AspNetCore.Mvc;

using TeacherService.Models;
using TeacherService.Repositories.Interfaces;

namespace TeacherService.Controllers
{
  [ApiController]
  public class TeachersController : ControllerBase
  {
    private ITeacherRepository TeacherRepository;
    public TeachersController(ITeacherRepository teacherRepository)
    {
      TeacherRepository = teacherRepository;
    }

    [HttpGet("/api/teachers/all")]
    public IActionResult Get()
    {
      var teachers = TeacherRepository.GetAll();
      return Ok(teachers);
    }

    [HttpGet("/api/teachers/{id}")]
    public IActionResult Get(int id)
    {
      var teacher = TeacherRepository.GetTeacher(id);
      if (teacher == null)
      {
        return NotFound();
      }
      return Ok(teacher);
    }

    [HttpPost("/api/teachers/create")]
    public IActionResult Create([FromBody] Teacher teacher)
    {
      var result = TeacherRepository.Create(teacher);
      if (result)
      {
        return Ok("Created Successfully");
      }
      return BadRequest();
    }

    [HttpPut("/api/teachers/{id}")]
    public IActionResult Update(int id, [FromBody] Teacher teacher)
    {
      var result = TeacherRepository.Update(id, teacher);
      if (result)
      {
        return Ok("Updated Sucessfully");
      }
      return BadRequest();
    }

    [HttpDelete("/api/teachers/{id}")]
    public IActionResult Delete(int id)
    {
      var result = TeacherRepository.Delete(id);
      if (result)
      {
        return Ok("Deleted Successfully");
      }
      return BadRequest();
    }
  }
}
