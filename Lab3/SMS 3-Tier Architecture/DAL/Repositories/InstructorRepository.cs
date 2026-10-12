using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class InstructorRepository
    {
        private readonly SchoolDbContext _context;
        public InstructorRepository()
        {
            _context = new SchoolDbContext();
        }

        public List<Instructor> GetAllInstructors()
        {
            return _context.Instructors.ToList();
        }

        public void AddInstructor(Instructor instructor)
        {
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
        }
    }
}