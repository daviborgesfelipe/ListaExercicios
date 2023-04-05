namespace ListaExercicios.ExercicioDezoito
{
    internal class OrdemDescrescente
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int a, b, c, maior, menor, meio;
                Console.WriteLine("Digite três números inteiros diferentes:");
                Console.Write("Número 1: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Número 2: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Número 3: ");
                c = int.Parse(Console.ReadLine());
                maior = a;
                if (b > maior)
                {
                    maior = b;
                }
                if (c > maior)
                {
                    maior = c;
                }
                menor = a;
                if (b < menor)
                {
                    menor = b;
                }
                if (c < menor)
                {
                    menor = c;
                }
                meio = (a + b + c) - (maior + menor);
                Console.WriteLine("Os números em ordem decrescente são: " + maior + ", " + meio + " e " + menor);
                Console.ReadLine();
            }
        }
    }
}