using System;

namespace c7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int LosowaLiczba = rnd.Next(1, 11);
            int MojaLiczba;
            int ileRazy = 0;
            Console.WriteLine("zgadnij liczbe od 1 do 10");
            do
            {
                ileRazy++;
                 Console.Write("podaj liczbe:");
                 MojaLiczba = int.Parse(Console.ReadLine());
                if (LosowaLiczba > MojaLiczba)
                {
                    Console.WriteLine("liczba jest wieksza");
                }
                else if (MojaLiczba > LosowaLiczba) 
                {
                    Console.WriteLine("liczba jest mniejsza");
                }
                else
                {
                    Console.WriteLine("WYGRALES! za "+ileRazy+ ". razem");
                }
            } while (LosowaLiczba != MojaLiczba);



             Console.ReadKey();
                
            
        }
    }
}

