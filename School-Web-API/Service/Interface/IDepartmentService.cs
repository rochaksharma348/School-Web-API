using School_Web_API.Models;
using School_Web_API.Models.DTO;

namespace School_Web_API.Service.Interface
{
    public interface IDepartmentService
    {
        public List<Department> GetDepartments();
        public void AddDepartment(DepartmentDTO department);
    }
}
