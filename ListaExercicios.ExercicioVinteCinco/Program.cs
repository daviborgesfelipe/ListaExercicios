namespace ListaExercicios.ExercicioVinteCinco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            while (true) 
            {
                Console.WriteLine("============================");
                Console.WriteLine("Digite um número de 1 a 10: ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("Tabuada do {0}:", n);
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = n * i;
                    Console.WriteLine(n + " x " + i +" = "+ resultado);
                }
            }
            Console.ReadLine();
        }
    }
}