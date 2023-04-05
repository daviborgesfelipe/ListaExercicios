namespace ListaExercicios.ExercicioTreze
{
    internal class Hotpao
    {
        static void Main(string[] args)
        {
            int totalPaozinho;
            int totalBroa;
            double valorPaozinho = 0.12;
            double valorBroa = 1.50;
            double valorTotal;
            double poupanca;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("Digite a quantidade de paozinho vendido:");
                totalPaozinho = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("========================================");

                Console.WriteLine("Digite a quantidade de broa vendida: ");
                totalBroa = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("========================================");
                valorTotal = (totalPaozinho * valorPaozinho) + (totalBroa * valorBroa);
                double parcelaPoupanca = valorTotal % 0.1; 
                Console.WriteLine("=================Resultado==============");

                Console.WriteLine("Valor do total de vendas: R$" + Math.Round(valorTotal, 2));
                Console.WriteLine("Valor para poupanca é de: R$" + Math.Round(parcelaPoupanca, 3));

                Console.WriteLine("========================================");

                Console.ReadLine();
            }
        }
    }
}