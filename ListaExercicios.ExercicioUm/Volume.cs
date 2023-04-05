namespace ListaExercicios.ExercicioUm
{
    internal class Volume
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== Formula = L x A x C ========");
                Console.WriteLine("=================================");
                Console.WriteLine("Digite a largura do triangulo:");
                int Largura = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("=================================");
                Console.WriteLine("Digite a altura do triangulo:");
                int Altura = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("=================================");
                Console.WriteLine("Digite o comprimento do triangulo:");
                int Comprimento = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("========== Volume ===============");
                int Volume = Largura * Altura * Comprimento;
                Console.WriteLine("Resultado: " + Volume);
                Console.WriteLine("=================================");
                Console.ReadLine();
            }
        }
    }
}