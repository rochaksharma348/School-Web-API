using Microsoft.AspNetCore.Mvc;
using School_Web_API.Models.DTO;
using School_Web_API.Service.Interface;

namespace School_Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet(Name = "get-students")]
        public IActionResult GetStudents()
        {
            var students = _studentService.GetStudents();
            return Ok(students);
        }

        [HttpPost(Name = "add-student")]
        public IActionResult AddStudent(StudentDTO studentDTO)
        {
            _studentService.AddStudent(studentDTO);
            return Created();
        }
    }
}
