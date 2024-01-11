
using SchoolApp.Repository;
using SchoolApp.Models;
using System.Linq.Expressions;

namespace SchoolApp.Repository
{
    class CoursesRepositoryMem : IRepository<Course>
    {

        private List<Course> _courses;

        public CoursesRepositoryMem()
        {
            _courses = new List<Course>();
        }


        public void Delete(Course entity)
        {
            throw new NotImplementedException();
        }

        public IList<Course> GetAll()
        {


            return _courses;

        }

        public Course GetById(int id)
        {
            return _courses[id];
        }

        public void Insert(Course entity)
        {
            _courses.Add(entity);
        }

        public bool Save(Course entity, Expression<Func<Course, bool>> predicate)
        {



            Course findCourse = (SearchFor(predicate)).FirstOrDefault();

            if (findCourse == null)
            {
                Insert(entity);
                return true;
            }
            return false;
        }

        public IList<Course> SearchFor(Expression<Func<Course, bool>> predicate)
        {
            return _courses.AsQueryable().Where(predicate).ToList();
        }
    }
}
