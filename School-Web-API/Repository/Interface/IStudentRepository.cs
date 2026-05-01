using School_Web_API.Models;
using School_Web_API.Models.DTO;

namespace School_Web_API.Repository.Interface
{
    public interface IStudentRepository
    {
        public List<Student> GetStudents();
        public void AddStudent(StudentDTO student);
    }
}
