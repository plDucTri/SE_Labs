using DAL.Model;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class InstructorService
    {
        private readonly InstructorRepository _instructorRepository;

        public InstructorService()
        {
            _instructorRepository = new InstructorRepository();
        }

        public List<Instructor> GetAllInstructors()
        {
            return _instructorRepository.GetAllInstructors();
        }

        public void AddInstructor(Instructor instructor)
        {
            _instructorRepository.AddInstructor(instructor);
        }
    }
}