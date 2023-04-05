namespace ListaExercicios.ExercicioDoze
{
    internal class TerrenoImobiliaria
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("====    Formula = L x L     =====");
                Console.WriteLine("=================================");
                Console.WriteLine("Digite o tamanho do primeiro lado:");
                int ladoUm = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("=================================");
                Console.WriteLine("Digite o tamanho do segundo lado:");
                int ladoDois = Convert.ToInt16(Console.ReadLine());
                if (ladoUm == ladoDois)
                { 
                    Console.WriteLine("Lados estao iguais");
                    continue;
                }
                if(ladoUm == 0)
                { 
                    Console.WriteLine("Lados é igual a zero");
                    ladoUm = Convert.ToInt16(Console.ReadLine());
                    continue;
                }
                if(ladoDois == 0)
                {
                    Console.WriteLine("Lados é igual a zero");
                    ladoDois = Convert.ToInt16(Console.ReadLine());
                    continue;
                }

                Console.WriteLine("=================================");
                Console.WriteLine("========== Volume ===============");
                int Volume = ladoUm * ladoUm;
                Console.WriteLine("Resultado: " + Volume);
                Console.WriteLine("=================================");
                Console.ReadLine();
            }
        }
    }
}