using Microsoft.AspNetCore.Mvc;
using StudentApi.Models;
using StudentApi.Services;


namespace StudentApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            var students = _studentService.GetStudents();
            return Ok(students);
        }

        
        [HttpPost("PostAllStudents")]
         public IActionResult AddStudent([FromBody] Student student)
         {
        _studentService.AddStudent(student);
        return Ok("Student added successfully");
        }

        [HttpPut("UpdateStudent/{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] Student student)
        {
        try{
            _studentService.UpdateStudent(id,student);
            return Ok("Student updated successfully");
           }
         catch(KeyNotFoundException ex)
          {
            return NotFound(ex.Message);
          }
        }

        [HttpDelete("DeleteStudent/{id}")]
        public IActionResult DeleteStudent(int id)
        {
         try
         {
            _studentService.DeleteStudent(id);
            return Ok($"Student with Id {id} Deleted successfully");
          }
         catch(KeyNotFoundException ex)
          {
            return NotFound(ex.Message);
          }
        }

    }
}
