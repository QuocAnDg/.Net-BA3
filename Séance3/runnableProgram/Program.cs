using Séance3.Models;

namespace runnableProgram
{
    public class Program
    {

        static void Main(string[] args)
        {
            NorthwindContext dc = new NorthwindContext();


            // EXERCICE 2

            var exo2 = from p in dc.Products
                       select p;
            String bevarages = "Beverages";
            String condiments = "Condiments";
            Console.WriteLine("Catégorie: beverages");
            foreach (var s in exo2)
            {
                if (s.Category.CategoryName == bevarages)
                {

                    Console.WriteLine("{0}", s.ProductName);
                }

            }
            Console.WriteLine("Catégorie: condiments");
            foreach (var s in exo2)
            {
                if (s.Category.CategoryName == condiments)
                {
                    Console.WriteLine("{0}", s.ProductName);
                }

            }


        }

    }
}