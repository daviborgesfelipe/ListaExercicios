namespace ListaExercicios.ExercicioVinteTres
{
    internal class NumerosImpar
    {
        static void Main(string[] args)
        {
            Console.Clear();
            while (true) 
            { 
                Console.Clear();
                Console.WriteLine("====");
                for (int i = 101; i <= 199; i += 2)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("====");
                Console.ReadLine();
            }
        }
    }
}