using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DepartmentRepository
    {
        private readonly SchoolDbContext _context;

        public DepartmentRepository()
        {
            _context = new SchoolDbContext();
        }

        public List<Department> GetAllDepartments()
        {
            return _context.Departments.ToList();
        }

        public void AddDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
        }
    }
}