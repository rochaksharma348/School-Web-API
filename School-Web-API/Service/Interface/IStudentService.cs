using School_Web_API.Models;
using School_Web_API.Models.DTO;

namespace School_Web_API.Service.Interface
{
    public interface IStudentService
    {
        public List<Student> GetStudents();
        public void AddStudent(StudentDTO student);
    }
}
