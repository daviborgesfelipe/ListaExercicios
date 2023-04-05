namespace ListaExercicios.ExercicioQuatro
{
    internal class KmPorLitro
    {
        static void Main(string[] args)
        {
            double InicioKm;
            double FinalKm;
            double QntdCombustivel;
            double PercorridoKm;
            double Media;
            while (true) 
            {
                Console.Clear();
                Console.WriteLine("==== Formula  Km/L ================");
                Console.WriteLine("===================================");
                Console.WriteLine("Digite a Quilometragem inicial");
                InicioKm = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("===================================");
                Console.WriteLine("Digite a Quilometragem final");
                FinalKm = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("===================================");
                Console.WriteLine("Digite a Quantidade de combustivel");
                QntdCombustivel = Convert.ToDouble(Console.ReadLine());
                PercorridoKm = FinalKm - InicioKm;
                Media = PercorridoKm / QntdCombustivel;
                Console.WriteLine("===================================");
                Console.WriteLine("Media: " + Media + "Km/L");
                Console.WriteLine("Distancia percorrida: " + PercorridoKm + "Km");
                Console.WriteLine("===================================");
                Console.ReadLine();
            }
        }
    }
}