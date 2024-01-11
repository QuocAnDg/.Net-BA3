using SchoolApp.Models;
using SchoolApp.Repository;

namespace SchoolApp
{
    public class Program
    {

        static void Main(string[] args)
        {
            SchoolContext dc = new SchoolContext();
            IRepository<Section> repoSect = new SectionsRepositoryMem();
            Section sectInfo = new Section { Name = "Informatique" };
            Section sectDiet = new Section {Name = "Diétique"};

            repoSect.Save(sectInfo, s => s.Name.Equals(sectInfo.Name));
            repoSect.Save(sectDiet, s => s.Name.Equals(sectDiet.Name));

            var exo1 = from p in dc.Sections
                       select p;
            foreach (var s in exo1)
            {
                    Console.WriteLine("{0}", s.Name);


            }
        }

    }
}