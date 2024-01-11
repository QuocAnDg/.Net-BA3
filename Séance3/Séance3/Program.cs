using Séance3.Models;

namespace runnableProgram
{
    public class Program
    {

        static void Main(string[] args)
        {
            NorthwindContext dc = new NorthwindContext();
            // EXERCICES 1

            Console.Write("b1 - Recherche clients par ville : ");
            string userInput = Console.ReadLine();
            var exo1 = from c in dc.Customers
                       where c.City == userInput
                       select new { NomComplet = c.ContactName};
            foreach (var s in exo1)
            {
                Console.WriteLine("nom complet = {0}", s.NomComplet);
            }




        }

    }
}