using System;

namespace uppgift_2_3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar vill du hyra bilen?...");
            String x = Console.ReadLine();
            Console.WriteLine("Hur många kilometer vill du köra med bilen?...");   
            String y = Console.ReadLine();

            int dagar = int.Parse(x);
            int km = int.Parse(y);
            int sum = dagar * 500 - 500 + km * 1 + 300;
            Console.WriteLine("Det kommer kosta "+ sum +" kr att hyra bilen.");
            Console.ReadKey();
        }
    }
}
