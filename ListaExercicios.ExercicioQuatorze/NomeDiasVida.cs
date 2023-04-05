namespace ListaExercicios.ExercicioQuatorze
{
    internal class NomeDiasVida
    {
        static void Main(string[] args)
        {
            string nome;
            DateTime dataNascimento;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("========================================");
                Console.WriteLine("Digite a data de nascimento da pessoa no formato dd/mm/aaaa: ");
                Console.WriteLine("========================================");
                dataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                int idadeDias = (DateTime.Today - dataNascimento).Days;
                Console.WriteLine("=================Resultado==============");
                Console.WriteLine(nome + ", você já viveu " + idadeDias + " dias.");
                Console.WriteLine("========================================");
                Console.ReadLine();
            }
        }
    }
}