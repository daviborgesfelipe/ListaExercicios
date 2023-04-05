namespace ListaExercicios.ExercicioCinco
{
    internal class EsferaVol
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== Formula (4/3) * π * r^3 ======");
                Console.WriteLine("===================================");
                Console.WriteLine("Digite o raio: ");
                double raio = Convert.ToDouble(Console.ReadLine());
                double pi = Math.PI;
                double volume = Math.Pow(raio, 3);
                volume = volume * pi;
                volume = (4.0 / 3.0 ) * volume;
                volume = Math.Round(volume, 2);
                Console.WriteLine("===================================");
                Console.WriteLine("O volume é: " + volume);
                Console.WriteLine("===================================");
                Console.ReadLine();
            }
        }
    }
}