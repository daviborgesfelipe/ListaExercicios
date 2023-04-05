namespace ListaExercicios.ExercicioDezenove
{
    internal class IndiciMassaCorporal
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;
            while (true)
            {
                Console.Clear();
                int a, b, c, maior, menor, meio;
                Console.WriteLine("=============================");
                Console.WriteLine("Digite o seu peso em quilos: ");
                peso = double.Parse(Console.ReadLine());
                Console.WriteLine("=============================");
                Console.WriteLine("Número sua altura em metros: ");
                altura = double.Parse(Console.ReadLine());
                imc = Math.Pow(altura,2);
                imc = peso / imc;
                Console.WriteLine("=============================");
                Console.WriteLine("Seu IMC é de " + Math.Round(imc, 3));
                Console.WriteLine("=============================");
                if (imc < 18.5)
                {
                    Console.WriteLine("Você está abaixo do peso.");
                }
                else if (imc < 25)
                {
                    Console.WriteLine("Você está no peso normal.");
                }
                else if (imc < 30)
                {
                    Console.WriteLine("Você está acima do peso.");
                }
                else
                {
                    Console.WriteLine("Você está obeso.");
                }
                Console.WriteLine("=============================");
                Console.ReadLine();
            }
        }
    }
}