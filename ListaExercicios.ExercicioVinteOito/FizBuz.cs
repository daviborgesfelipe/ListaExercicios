namespace ListaExercicios.ExercicioVinteOito
{
    internal class FizBuz
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++) 
            {
                if (i % 2 == 0 && i % 5 == 0) 
                {
                    Console.WriteLine("FizBuzz");
                }else if (i % 3 == 0)
                {
                    Console.WriteLine("Fiz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }else
                {
                    Console.WriteLine(Convert.ToString(i) + " ");
                }
            }
        }
    }
}