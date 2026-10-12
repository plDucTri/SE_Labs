using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class StudentRepository
    {
        private readonly SchoolDbContext _context;

        public StudentRepository()
        {
            _context = new SchoolDbContext();
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            var existing = _context.Students.FirstOrDefault(s => s.StudentID == student.StudentID);

            if (existing != null)
            {
                existing.StudentName = student.StudentName;
                existing.DateOfBirth = student.DateOfBirth;
                existing.City = student.City;
                existing.Age = student.Age;
                existing.YearOfEnroll = student.YearOfEnroll;
                existing.Major = student.Major;
                existing.GPA = student.GPA;
                _context.SaveChanges();
            }
        }

        public void DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);

            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }
    }
}