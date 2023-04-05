namespace ListaExercicios.ExercicioVinteUm
{
    internal class DoisNumeros
    {
        static void Main(string[] args)
        {
            int A, B, C;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("Digite o primeiro numero: ");
                A = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("=================================");
                Console.WriteLine("Digite o segundo numero: ");
                B = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("=================================");
                if (A != B) 
                {
                    C = A * B;
                }
                else
                {
                    C = A + B;
                }
                Console.WriteLine("O resultado é: " + C);
                Console.WriteLine("=================================");
                Console.ReadLine();
            }
        }
    }
}