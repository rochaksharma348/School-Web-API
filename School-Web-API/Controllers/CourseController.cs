using Microsoft.AspNetCore.Mvc;
using School_Web_API.Models.DTO;
using School_Web_API.Repository.Interface;
using School_Web_API.Service.Interface;

namespace School_Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpGet(Name = "get-courses")]
        public IActionResult GetCourses()
        {
            var courses = _courseRepository.GetCourses();
            return Ok(courses);
        }

        [HttpPost(Name = "add-course")]
        public IActionResult AddCourse(CourseDTO courseDTO)
        {
            _courseRepository.AddCourse(courseDTO);
            return Created();
        }
    }
}
