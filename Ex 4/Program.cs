using System;

namespace Ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de média etc\n\nDigite os 5 números");
            double a = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());
                        
            double media = (a + b + c + d + e) / 5;

            int positivos = 0;
            int negativos = 0;

            Console.WriteLine($"A média aritmética é: {media}");

            if (a>=0)
            {
                positivos++;
            }
            if (b>=0)
            {
                positivos++;
            }
            if (c >= 0)
            {
                positivos++;
            }
            if (d >= 0)
            {
                positivos++;
            }
            if (e >= 0)
            {
                positivos++;
            }
            //Negativos:
            if (a < 0)
            {
                negativos++;
            }
            if (b < 0)
            {
                negativos++;
            }
            if (c < 0)
            {
                negativos++;
            }
            if (d < 0)
            {
                negativos++;
            }
            if (e < 0)
            {
                negativos++;
            }

            Console.WriteLine($"\nNúmeros positivos: {positivos}\nNúmeros negativos {negativos}");
        }
    }
}
