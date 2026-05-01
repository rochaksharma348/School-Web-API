using School_Web_API.Models;
using School_Web_API.Models.DTO;
using School_Web_API.Repository.Interface;

namespace School_Web_API.Repository.Implementation
{
    public class CourseRepository : ICourseRepository
    {
        private List<Course> _courses;

        public CourseRepository()
        {
            _courses = new List<Course>();
        }

        public void AddCourse(CourseDTO course)
        {
            _courses.Add(new Course()
            {
                CourseID = _courses.Count + 1,
                Credits = course.Credits,
                DepartmentID = course.DepartmentID,
                Description = course.Description,
                Name = course.Name,
            });
        }

        public List<Course> GetCourses()
        {
            return _courses;
        }
    }
}
