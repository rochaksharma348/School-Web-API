using School_Web_API.Models;
using School_Web_API.Models.DTO;
using School_Web_API.Repository.Interface;

namespace School_Web_API.Repository.Implementation
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> _students;

        public StudentRepository()
        {
            _students = new List<Student>();
        }
        public void AddStudent(StudentDTO student)
        {
            _students.Add(new Student()
            {
                StudentID = _students.Count + 1,
                FullName = student.FullName,
                BirthDate = student.BirthDate,
                Email = student.Email,
                Gender = student.Gender,
                Phone = student.Phone,
            });
        }

        public List<Student> GetStudents()
        {
            return _students;
        }
    }
}
