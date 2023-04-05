namespace ListaExercicios.ExercicioSete
{
    internal class SalarioTotal
    {
        static void Main(string[] args)
        {
            double salarioTotal;
            double salarioBase;
            double totalVendas;
            double percentual;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Formula  per/100 * totalVendas + salarioBase ===");
                Console.WriteLine("====================================================");
                Console.WriteLine("Digite a Salario Base");
                salarioBase = Convert.ToDouble(Console.ReadLine());
                salarioBase = Math.Round(salarioBase, 2);
                Console.WriteLine(salarioBase);
                Console.WriteLine("====================================================");
                Console.WriteLine("Digite o total de vendas");
                totalVendas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("====================================================");
                Console.WriteLine("Digite o percentual da comissao");
                percentual = Convert.ToDouble(Console.ReadLine());
                percentual = Math.Round(percentual, 2);
                Console.WriteLine(percentual);
                salarioTotal = ((percentual/100) * totalVendas) + salarioBase;
                salarioTotal = Math.Round(salarioTotal, 2);
                Console.WriteLine(salarioTotal);
                Console.WriteLine("====================================================");
                Console.WriteLine("Salario total: R$" + salarioTotal);
                Console.WriteLine("====================================================");
                Console.ReadLine();
            }
        }
    }
}