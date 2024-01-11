using SchoolApp.Models;
using SchoolApp.Repository;

namespace RunnableProgram
{
    public class Program
    {

        static void Main(string[] args)
        {
    
            SchoolContext dc = new SchoolContext();
            IRepository<Section> repoSect = new SectionsRepositoryMem();
            Section sectInfo = new Section { Name = "Informatique", SectionId = 1 };

            repoSect.Save(sectInfo, s => s.Name.Equals(sectInfo.Name));
            Section sectDiet = new Section { Name = "Diétique", SectionId = 2 };

            repoSect.Save(sectDiet, s => s.Name.Equals(sectDiet.Name));

            // renvoyer toutes les sections

            IList<Section> sections = repoSect.GetAll().ToList();

            Console.WriteLine("----------- SECTIONS --------------------");
            foreach (Section s in sections)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine("-----------------------------------------");


        }

    }
}