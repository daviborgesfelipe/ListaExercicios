namespace ListaExercicios.ExercicioOnze
{
    internal class NumeroPrimo
    {
        static void Main(string[] args)
        {
            int numero;
            bool confirmaNumero = true;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== Formula  N achei              ====");
                Console.WriteLine("=======================================");
                Console.WriteLine("Digite o numero desejado");
                numero = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("=======================================");
                for (int i = 2; i < numero; i++) 
                {
                    if (numero % i == 0) 
                    {
                        confirmaNumero = false;
                        break;
                    }
                }
                
                if(confirmaNumero)
                {
                    Console.WriteLine("O numero " + numero + " é primo");
                } else 
                {
                    Console.WriteLine("O numero " + numero + " nao é primo");
                }
                Console.WriteLine("=======================================");
                Console.ReadLine();
            }
        }
    }
}