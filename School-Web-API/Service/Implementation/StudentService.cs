using School_Web_API.Models;
using School_Web_API.Models.DTO;
using School_Web_API.Repository.Interface;
using School_Web_API.Service.Interface;

namespace School_Web_API.Service.Implementation
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository) { 
            _studentRepository = studentRepository;
        }

        public void AddStudent(StudentDTO student)
        {
            _studentRepository.AddStudent(student);
        }

        public List<Student> GetStudents()
        {
            return _studentRepository.GetStudents();
        }
    }
}
