using System;

namespace Lista_Ex_Presencial.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos construir um retângulo com asteriscos");

            Console.WriteLine("Digite a largura do retângulo");
            int x = Convert.ToInt32(Console.ReadLine());    

            Console.WriteLine("Digite a altura do retângulo");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n");

             
            
            
            for (int i = 0; i < y; i++)
            {
                

                for (int j = 0; j < x; j++) 
                {

                    Console.Write("*");


                }
                Console.WriteLine();
            }
        }
    }
}
