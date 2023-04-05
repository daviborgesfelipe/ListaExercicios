namespace ListaExercicios.ExercicioDez
{
    internal class MediaPonderada
    {
        static void Main(string[] args)
        {
            double notaUm;
            double notaDois;
            double pesoUm;
            double pesoDois;
            double media;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== Formula  n1+n2+n3 / totalNota ====");
                Console.WriteLine("=======================================");
                Console.WriteLine("Digite a primeira nota");
                notaUm = Convert.ToDouble(Console.ReadLine());
                while (notaUm > 10 || notaUm < 0)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Nota um nao pode ser maior que 10 ou menor que 0");
                    Console.WriteLine("=======================================");
                    notaUm = Convert.ToDouble(Console.ReadLine());
                    continue;
                }
                Console.WriteLine("=======================================");
                Console.WriteLine("Digite a segunda nota");
                notaDois = Convert.ToDouble(Console.ReadLine());
                while (notaDois > 10 || notaDois < 0)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Nota dois nao pode ser maior que 10 ou menor que 0");
                    Console.WriteLine("=======================================");
                    notaDois = Convert.ToDouble(Console.ReadLine());
                    continue;
                }
                Console.WriteLine("=======================================");
                Console.WriteLine("Digite o peso da primeira nota");
                pesoUm = Convert.ToDouble(Console.ReadLine());
                while (pesoUm > 10 || pesoUm < 0)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Peso nao pode ser maior que 10 ou menor que 0");
                    Console.WriteLine("=======================================");
                    pesoUm = Convert.ToDouble(Console.ReadLine());
                    continue;
                }
                Console.WriteLine("=======================================");
                Console.WriteLine("Digite o peso da segunda nota");
                pesoDois = Convert.ToDouble(Console.ReadLine());
                while (pesoDois > 10 || pesoDois < 0)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Peso nao pode ser maior que 10 ou menor que 0");
                    Console.WriteLine("=======================================");
                    pesoDois = Convert.ToDouble(Console.ReadLine());
                    continue;
                }
                Console.WriteLine("=======================================");
                media = ((notaUm * pesoUm) + (notaDois * pesoDois)) / (pesoDois + pesoUm);
                media = Math.Round(media, 2);
                Console.WriteLine("Media é: " + media);
                Console.WriteLine("=======================================");
                Console.ReadLine();
            }
        }
    }
}