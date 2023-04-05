namespace ListaExercicios.ExercicioTres
{
    internal class Cilindro
    {
        static void Main(string[] args)
        {
            double raio;
            double altura;
            double volume;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== Formula  V = pi * r^2 * a ====");
                Console.WriteLine("===================================");
                Console.WriteLine("Digite o raio do cilindro");
                raio = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("===================================");
                Console.WriteLine("Digite o altura do cilindro");
                altura = Convert.ToDouble(Console.ReadLine());
                volume = Math.PI * Math.Pow(raio, 2) * altura;
                volume = Math.Round(volume, 3);
                Console.WriteLine("===================================");
                Console.WriteLine("Volume é: " + volume);
                Console.WriteLine("===================================");
                Console.ReadLine();
            }
        }
    }
}