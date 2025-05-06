namespace MediaPonderada.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Olá, aqui iremos calcular a média ponderada de suas provas");
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Para começar, irei precisar das notas de suas provas:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("digite a nota de sua primeira prova");


                double provaUm = Double.Parse(Console.ReadLine());

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("digite a nota de sua segunda prova");


                double provaDois = Double.Parse(Console.ReadLine());

                Console.WriteLine("----------------------------------------");

                double media = (provaUm * (50 / 100.0)) + (provaDois * (50 / 100.0));



                Console.WriteLine($"A sua nota ponderada é de {media:0.##}");
                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
