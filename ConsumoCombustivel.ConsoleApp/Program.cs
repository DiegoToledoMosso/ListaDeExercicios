namespace ConsumoCombustivel.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                decimal comsumo = 0;

                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("Olá, aqui iremos calcular o consumo de combustível do seu veículo");
                Console.WriteLine("------------------------------------------------------------------");


                Console.WriteLine("Para começar, irei precisar de alguns dados iniciais:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Digite a quilômetragem do veículo no inicio da viagem por favor.");

                decimal quilometragemInicial = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Digite a quilômetragem do veículo no final da viagem por favor.");

                decimal quilomentragemFinal = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Digite a quantidade de combustível gasto durante a viagem(em litros)");

                decimal combustivel = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("----------------------------------------");

                comsumo = (quilomentragemFinal - quilometragemInicial) / combustivel;

                Console.WriteLine($"O consumo de combustível foi de : {comsumo:0.##} litros por quilômetro percorrido.");
                Console.WriteLine("----------------------------------------");
                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;

                Console.ReadLine();
            }
        }
    }
}
