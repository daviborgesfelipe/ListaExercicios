﻿namespace ListaExercicios.ExercicioSeis
{
    internal class Celsius
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("======  °F = (20 x 1,8) + 32 ======");
                Console.WriteLine("===================================");
                Console.WriteLine("Digite a temperatura em Celsius");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = (celsius - 1.8) + 32;
                fahrenheit = Math.Round(fahrenheit, 2);
                Console.WriteLine("===================================");
                Console.WriteLine(celsius + "°C é o mesmo que " + fahrenheit + "°F");
                Console.WriteLine("===================================");
                Console.ReadLine();
            }
        }
    }
}