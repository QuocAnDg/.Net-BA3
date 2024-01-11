using SchoolApp.Models;

namespace SchoolApp.Repository
{
    // Cette classe n'est pas nécessaire si vous n'ajoutez aucune autre méthode que le constructeur !!!
    public class SectionRepositorySQL : BaseRepositorySQL<Section>
    {
        public SectionRepositorySQL(SchoolContext context) : base(context) { }
    }
}
