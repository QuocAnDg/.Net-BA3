using SchoolApp.Models;

namespace SchoolApp.Repository
{
    // Cette classe n'est pas nécessaire si vous n'ajoutez aucune autre méthode que le constructeur !!!
    class StudentRepositorySQL : BaseRepositorySQL<Student>
    {
        public StudentRepositorySQL(SchoolContext context) : base(context) { }
    }
}
