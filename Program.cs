using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complete_me
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slumpat = new Random();
            int speltal = slumpat.Next();
            string input;
            int tal;
            speltal = 5;

            bool spela = true;

            while (spela)
            {
                Console.Write("\n\tGissa på ett tal mellan 1 och 20: ");
                input = Console.ReadLine();
                if (input == "q" || input == "Q")
                {
                    Console.WriteLine("Du har valt att avsluta, Ha det!");
                    spela = false;
                    return;
                }
                try
                {
                    tal = Convert.ToInt32(input);

                }
                catch (System.Exception)
                {
                    Console.WriteLine("Du kan inte skriva det!");
                    throw;
                }

                if (tal < speltal)
                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för litet, försök igen.");
                }

                if (tal > speltal)
                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för stort, försök igen.");
                }

                if (tal == speltal)
                {
                    Console.WriteLine("\tGrattis, du gissade rätt!");
                }

                spela = false;

            }

        }
    }
}
