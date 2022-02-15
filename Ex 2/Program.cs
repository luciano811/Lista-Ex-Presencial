using System;

namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos construir um retângulo intercalando 'AAA...' e 'BBB...'");

            Console.WriteLine("Digite a largura do retângulo");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a altura do retângulo");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n");




            for (int j = 0; j < y; j++)
            {
                

                for (int i = 0; i < x - 1; i++)
                {

                    if (j % 2 == 0)
                    {
                        Console.Write("B");
                    }
                        
                    else
                    {
                        Console.Write("A");
                    }                                        
                }
                Console.WriteLine();
            }
        }
    }
}