using School_Web_API.Models;
using School_Web_API.Models.DTO;
using School_Web_API.Repository.Interface;
using School_Web_API.Service.Interface;

namespace School_Web_API.Service.Implementation
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public void AddCourse(CourseDTO course)
        {
            _courseRepository.AddCourse(course);
        }

        public List<Course> GetCourses()
        {
            return _courseRepository.GetCourses();
        }
    }
}
