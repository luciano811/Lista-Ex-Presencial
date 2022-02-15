using System;

namespace Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa: Bom dia, Boa tarde, Boa noite.\n");

            Console.WriteLine("Digite a hora atual (sistema 24h)");
            int horaAtual = Convert.ToInt32(Console.ReadLine());
                      

            Console.WriteLine("\n\n");


                    if ((horaAtual >= 18 && horaAtual < 24) || (horaAtual >= 0 && horaAtual <= 5))
                    {
                        Console.Write("Boa noite!\n\n");
                    }

                    else if ((horaAtual > 5 && horaAtual <= 12))
                    {
                        Console.Write("Bom dia!\n\n");
                    }

                    else if ((horaAtual > 12 && horaAtual < 18))
                    {
                        Console.Write("Boa tarde!\n\n");
                    }

                    else
                    {
                    Console.Write("Hora inválida");
                    }

        }
    }
}