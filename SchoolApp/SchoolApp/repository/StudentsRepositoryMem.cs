using SchoolApp.Repository;
using SchoolApp.Models;
using System.Linq.Expressions;

namespace SchoolApp.Repository
{
    class StudentsRepositoryMem : IRepository<Student>
    {

        private List<Student> _etudiants;

        public StudentsRepositoryMem()
        {
            _etudiants = new List<Student>();
        }


        public void Delete(Student entity)
        {
            throw new NotImplementedException();
        }

        public IList<Student> GetAll()
        {


            return _etudiants;

        }

        public Student GetById(int id)
        {
            return _etudiants[id];
        }

        public void Insert(Student entity)
        {
            _etudiants.Add(entity);
        }

        public bool Save(Student entity, Expression<Func<Student, bool>> predicate)
        {



            Student findStudent = (SearchFor(predicate)).FirstOrDefault();

            if (findStudent == null)
            {
                Insert(entity);
                return true;
            }
            return false;
        }

        public IList<Student> SearchFor(Expression<Func<Student, bool>> predicate)
        {
            return _etudiants.AsQueryable().Where(predicate).ToList();
        }
    }
}
