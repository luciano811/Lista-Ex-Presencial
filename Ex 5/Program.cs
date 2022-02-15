using System;

namespace Ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao joguinho de dados\n\nDigite o nome do jogador 1:");

            string nome1 = Console.ReadLine();

            Console.WriteLine("\nDigite o nome do jogador 2:");

            string nome2 = Console.ReadLine();

            Console.WriteLine($"\n\nBatalha entre:\n{nome1} & {nome2}\n\n");

            int j1 = 0;
            int j2 = 0;

            Random dado = new Random();                             

            for (int i = 1; i <= 3; i++)
            {
                int dado1 = dado.Next(1, 7);
                int dado2 = dado.Next(1, 7);
                Console.WriteLine($"{i}° Rodada\n{nome1}: {dado1}\n{nome2}: {dado2}");

                if (dado1 > dado2)
                {
                    Console.WriteLine($"{nome1} venceu a {i}° rodada!\n");
                    j1++;                    
                }
                else if (dado2 > dado1)
                {
                    Console.WriteLine($"{nome2} venceu a {i}° rodada!\n");
                    j2++;                    
                }
                else
                {
                    Console.WriteLine("Houve um empate, tente novamente...\n\n");
                    i=i-1;
                    continue;
                }                                
            }
            if (j1 > j2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\n{nome1} venceu o jogo!!! \n\n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\n{nome2} venceu o jogo!!! \n\n");
                Console.ResetColor();
            }
        }
    }
}
