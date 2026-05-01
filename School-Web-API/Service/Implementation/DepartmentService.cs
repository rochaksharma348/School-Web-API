using School_Web_API.Models;
using School_Web_API.Models.DTO;
using School_Web_API.Repository.Interface;
using School_Web_API.Service.Interface;

namespace School_Web_API.Service.Implementation
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public void AddDepartment(DepartmentDTO department)
        {
            _departmentRepository.AddDepartment(department);
        }

        public List<Department> GetDepartments()
        {
            return _departmentRepository.GetDepartments();
        }
    }
}
