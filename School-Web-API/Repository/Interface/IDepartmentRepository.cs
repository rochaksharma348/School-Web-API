using School_Web_API.Models;
using School_Web_API.Models.DTO;

namespace School_Web_API.Repository.Interface
{
    public interface IDepartmentRepository
    {
        public List<Department> GetDepartments();
        public void AddDepartment(DepartmentDTO department);
    }
}
