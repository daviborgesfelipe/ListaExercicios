namespace ListaExercicios.ExercicioDezesseis
{
    internal class AumentoDesconto
    {
        static void Main(string[] args)
        {
            double salarioInicial;
            double salarioFinal;
            double salarioAumento;
            double aumento;
            double desconto;
            while (true) 
            {
                Console.Clear();
                Console.WriteLine("======  (Salario + 15%) - 8% ======");
                Console.WriteLine("===================================");
                Console.WriteLine("Digite o salario");
                salarioInicial = Convert.ToDouble(Console.ReadLine());
                aumento = (salarioInicial * 0.15);
                salarioAumento = aumento + salarioInicial;
                desconto = salarioAumento * 0.08;
                Math.Round(desconto, 3);
                salarioFinal = salarioAumento - desconto;
                Console.WriteLine("===================================");
                Console.WriteLine("Salario Inicial é de R$" + salarioInicial);
                Console.WriteLine("Salario com aumento é de R$" + salarioAumento);
                Console.WriteLine("Salario Final é de R$" + salarioFinal);
                Console.WriteLine("===================================");
                Console.ReadLine();
            }
        }
    }
}