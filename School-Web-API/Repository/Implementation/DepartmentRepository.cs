using School_Web_API.Models;
using School_Web_API.Models.DTO;
using School_Web_API.Repository.Interface;

namespace School_Web_API.Repository.Implementation
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private List<Department> _departments;

        public DepartmentRepository() {
            _departments = new List<Department>();
        }

        void IDepartmentRepository.AddDepartment(DepartmentDTO department)
        {
            // TO-DO: implement method to Add a Department
            throw new NotImplementedException();
        }

        List<Department> IDepartmentRepository.GetDepartments()
        {
            // TO-DO: implement method to Get Departments
            throw new NotImplementedException();
        }
    }
}
