using SchoolApp.Models;
using System.Linq.Expressions;

namespace SchoolApp.Repository
{
    public class SectionsRepositoryMem : IRepository<Section>
    {

        private List<Section> _sections;

        public SectionsRepositoryMem()
        {
            _sections = new List<Section>();
        }


        public void Delete(Section entity)
        {
            throw new NotImplementedException();
        }

        public IList<Section> GetAll()
        {


            return _sections;

        }

        public Section GetById(int id)
        {
            return _sections[id];
        }

        public void Insert(Section entity)
        {
            _sections.Add(entity);
        }

        public bool Save(Section entity, Expression<Func<Section, bool>> predicate)
        {



            Section findSection = (SearchFor(predicate)).FirstOrDefault();

            if (findSection == null)
            {
                Insert(entity);
                return true;
            }
            return false;
        }

        public IList<Section> SearchFor(Expression<Func<Section, bool>> predicate)
        {
            return _sections.AsQueryable().Where(predicate).ToList();
        }
    }
}
