using School_Web_API.Models;
using School_Web_API.Models.DTO;

namespace School_Web_API.Repository.Interface
{
    public interface ICourseRepository
    {
        public List<Course> GetCourses();
        public void AddCourse(CourseDTO course);
    }
}
