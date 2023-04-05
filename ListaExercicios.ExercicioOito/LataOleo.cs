namespace ListaExercicios.ExercicioOito
{
    internal class LataOleo
    {
        static void Main(string[] args)
        {
            double altura;
            double diametro;
            double raio;
            double volume;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== Formula  V = pi * r^2 * a ====");
                Console.WriteLine("===================================");
                Console.WriteLine("Digite o altura do cilindro");
                altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("===================================");
                Console.WriteLine("Digite o diametro do cilindro");
                diametro = Convert.ToDouble(Console.ReadLine());
                raio = diametro / 2;
                volume = Math.PI * Math.Pow(raio, 2) * altura;
                volume = Math.Round(volume, 2);
                Console.WriteLine("===================================");
                Console.WriteLine("Volume é: " + volume + "cm^3");
                volume = volume / 1000;
                volume = Math.Round(volume, 2);
                Console.WriteLine("Volume é: " + volume + "L");
                Console.WriteLine("===================================");
                Console.ReadLine();
            }
        }
    }
}