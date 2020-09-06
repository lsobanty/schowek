using System;

namespace c5
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int y = int.Parse(x)+2;
            Console.WriteLine(y);
            x = y.ToString();
            Console.WriteLine(x-"lubie placuszki");
           
            Console.ReadKey();

        }
    }
}
