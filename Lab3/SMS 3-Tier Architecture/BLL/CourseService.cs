using DAL.Model;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CourseService
    {
        private readonly CourseRepository _courseRepository;

        public CourseService()
        {
            _courseRepository = new CourseRepository();
        }

        public List<Course> GetAllCourses()
        {
            return _courseRepository.GetAllCourses();
        }

        public void AddCourse(Course course)
        {
            _courseRepository.AddCourse(course);
        }

        public void DeleteCourse(int id)
        {
            _courseRepository.DeleteCourse(id);
        }
    }
}