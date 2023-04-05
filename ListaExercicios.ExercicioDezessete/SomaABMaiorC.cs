namespace ListaExercicios.ExercicioDezessete
{
    internal class SomaABMaiorC
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;
            bool resultado;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("======  (A + B) > C ======");
                Console.WriteLine("==========================");
                Console.WriteLine("Digite a letra A");
                A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("==========================");
                Console.WriteLine("Digite a letra B");
                B = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("==========================");
                Console.WriteLine("Digite a letra C");
                C = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("===================================");
                resultado = (A + B) > C;
                if (resultado) 
                {
                    Console.WriteLine("O resultado de A + B é maior que C");
                }
                else
                {
                    Console.WriteLine("O resultado de A + B é menor que C");
                }
                Console.WriteLine("===================================");
                Console.ReadLine();
            }
        }
    }
}