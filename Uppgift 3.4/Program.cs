using System;

namespace Uppgift_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är låten? Svara med två heltal");
            int minut=int.Parse(Console.ReadLine());

            int sekund=int.Parse(Console.ReadLine());

            int x = minut * 60;
            int y = x + sekund;

            if (y <= 260 && y >= 165)
            {
                Console.WriteLine("Låten får spelas på radiostationen.");
            }
            else
            {
                Console.WriteLine("Låten får tyvärr inte spelas på radiostationen.");
            }
            Console.ReadKey();

        }
    }
}
