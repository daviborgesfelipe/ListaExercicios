using System;

namespace ListaExercicios.ExercicioVinte
{
    internal class ImparPar
    {
        static void Main(string[] args)

        {
            int numeroUm;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("Digite o primeiro numero:");
                numeroUm = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("=================================");
                if (numeroUm % 2 == 0)
                { 
                    Console.WriteLine("O número é par.", numeroUm);
                }
                else
                {
                    Console.WriteLine("O número é ímpar.", numeroUm);
                }
                Console.WriteLine("=================================");
                Console.ReadLine();
            }
        }
    }
}