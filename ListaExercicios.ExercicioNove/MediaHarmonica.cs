namespace ListaExercicios.ExercicioNove
{
    internal class MediaHarmonica
    {
        static void Main(string[] args)
        {
            double notaUm;
            double notaDois;
            double notaTres;
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
                ;
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
                Console.WriteLine("Digite a terceira nota");
                notaTres = Convert.ToDouble(Console.ReadLine());
                while (notaTres > 10 || notaTres < 0)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Nota tres nao pode ser maior que 10 ou menor que 0");
                    Console.WriteLine("=======================================");
                    notaTres = Convert.ToDouble(Console.ReadLine());
                    continue;
                }
                Console.WriteLine("=======================================");
                media =  (notaUm + notaDois + notaTres) / 3;
                media = Math.Round(media, 2);
                Console.WriteLine("Media é: " + media);
                Console.WriteLine("=======================================");
                Console.ReadLine();
            }
        }
    }
}