using System;

namespace mozliwypowrotD
{
    class Program
    {
        static void Main(string[] args)
        {
            int fdas;
            fdas = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < fdas; i++) 
            {
                Console.WriteLine("Hello luke, great to see you!");
                string odpowiedz = Console.ReadLine();
                if (odpowiedz == "hi" || odpowiedz == "czesc")
                {
                    Console.WriteLine("I didn't think you would've replied");
                }
                else
                {
                    Console.WriteLine("spierdalaj!");
                }
            }
           
        }
       
    }
}
