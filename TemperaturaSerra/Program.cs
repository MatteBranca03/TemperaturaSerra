using System;

namespace TemperaturaSerra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci la temperatura della serra");
            double t = double.Parse(Console.ReadLine());
            if (t < 5)
            {
                Console.WriteLine($"la temperatura è {t}, ATTENZIONE danni irreparabili");
                Console.ReadLine();
            }
            if (t > 5 && t < 18)
            {
                Console.WriteLine($"la temperatura è {t}, ATTENZIONE situazione di pericolo");
                Console.ReadLine();
            }
            if (t == 18)
            {
                Console.WriteLine($"la temperatura è {t}, la serra è in una temperatura normale");
                Console.ReadLine();
            }
        }
    }
}
