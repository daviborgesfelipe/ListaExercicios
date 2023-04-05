namespace ListaExercicios.ExercicioVinteSeis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, fatorial = 1;
            Console.WriteLine("Digite um valor inicial: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write(a + "! = ");
            for (int i = a; i >= 1; i--) 
            {
                Console.Write(i + " ");
                fatorial *= i;
                if (fatorial > 1)
                {
                    Console.Write(" X ");
                }
            }
        }
    }
}