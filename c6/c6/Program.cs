using System;

namespace c6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj szerokość: ");
            string xs = Console.ReadLine();
            Console.Write("Podaj wysokość ");
            string ys = Console.ReadLine();                     //przykladowy program z kanalu o wszystkim

            int x = int.Parse(xs);
            int y = int.Parse(ys);
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
