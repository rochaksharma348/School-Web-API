using School_Web_API.Models;
using School_Web_API.Models.DTO;

namespace School_Web_API.Service.Interface
{
    public interface ICourseService
    {
        public List<Course> GetCourses();
        public void AddCourse(CourseDTO course);
    }
}
