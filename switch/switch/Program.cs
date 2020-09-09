using System;

namespace switch1
{
    class Program
{
    static void Main(string[] args)
    {
        int liczba;
        liczba=int.Parse(Console.ReadLine());

            //if (liczba == 1)
            //{
            //    Console.WriteLine("Jeden");
            //}
            //else if (liczba == 2)
            //{
            //    Console.WriteLine("dwa");
            //}
            //else if (liczba == 3)
            //{
            //    Console.WriteLine("trzy");
            //}
            //else
            //{
            //    Console.WriteLine("inna wartosc");
            //}
            switch (liczba)
            {
                case 1:
                    Console.WriteLine("jeden");
                    goto koniec;
                case 2:
                    Console.WriteLine("dwa");
                    goto case 3;
                case 3:
                    Console.WriteLine("trzy");
                    break;
                default:
                    Console.WriteLine("inna wartosc");
                    break;
                

            }
            Console.WriteLine("test");
            koniec:
            Console.WriteLine("koniec");
            Console.ReadLine();
    }
}
}
