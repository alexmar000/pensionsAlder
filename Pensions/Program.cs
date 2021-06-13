using System;

namespace Pensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcome = "Välkommen till pensionsuträknaren! Vad heter ni? ";
            string ageq = "Vad är din ålder?";
            string name;
            string ageNr;
            int age;
            
            Console.WriteLine(welcome);
            name = Console.ReadLine();
            Console.WriteLine(ageq);
            ageNr = Console.ReadLine();
            age = Convert.ToInt32(ageNr); // Konverterar från string till int
            int older = age - 65;
            int pension = 65 - age;
            if (age > 65)
            {
                Console.Write("Hej " + name + ", Ni gick i pension för " + older + " År sedan.");
            }
            else if (age == 65)
            {
                Console.Write("Hej " + name + ", Ni går i pension i år!");
            }
            else
            {
                Console.Write("Hej " + name + ", Ni går i pension om " + pension + " År!");
            }
            Console.ReadKey();

        }
    }
}
