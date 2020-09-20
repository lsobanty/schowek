using System;
using System.Globalization;

namespace KalkulatorBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Obliczę twoj współczynnik bmi");
            Console.WriteLine("Podaj swoją masę[kg]");
            string masa=Console.ReadLine();
            double a = double.Parse(masa);
            Console.WriteLine("Podaj swój wzrost[m]");
            string wzrost = Console.ReadLine();
            double b = double.Parse(wzrost);
            double c = a / (b * b);
            Console.WriteLine("Twoje BMI wynosi" + " " + c);
            if(c < 18.5)
            {
                Console.WriteLine("Masz Niedowagę");
            }
            else if(c>24.99)
            {
                Console.WriteLine("Masz Nadwagę");
            }
            else
            {
                Console.WriteLine("Twoja waga jest w normie");
            }
            Console.ReadKey();

        }
    }
}
