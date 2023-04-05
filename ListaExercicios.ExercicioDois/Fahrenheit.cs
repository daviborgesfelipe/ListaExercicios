namespace ListaExercicios.ExercicioDois
{
    internal class Fahrenheit
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();
                Console.WriteLine("==== Formula (°F - 32) * 5 / 9 ====");
                Console.WriteLine("===================================");
                Console.WriteLine("Digite a temperatura em Fahrenheit");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = (fahrenheit - 32) * 5 / 9;
                celsius = Math.Round(celsius,2);
                Console.WriteLine("===================================");
                Console.WriteLine(fahrenheit + "°F é o mesmo que " + celsius + "°C");
                Console.WriteLine("===================================");
                Console.ReadLine();
            }
        }
    }
}