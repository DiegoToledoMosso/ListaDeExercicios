namespace PadariaHotPao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Olá, somos a Padaria Hotpão");
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Para começar, irei precisar da quantidade de pães e broas vendidos hoje:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Digite a quantidade de pães vendidos:");

                decimal paesVendidos = 0m;
                paesVendidos = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Digite a quantidade de broas vendidas:");

                decimal broasVendidas = 0m;
                broasVendidas = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("----------------------------------------");

                decimal pao = 0m;
                pao = paesVendidos * 0.12m;

                decimal broas = 0m;
                broas = broasVendidas * 1.5m;

                decimal valorTotal = pao + broas;

                decimal valorPoupanca = 0m;
                valorPoupanca = valorTotal * 0.1m;

                Console.WriteLine("Valor total arrecadado foi de " + valorTotal + " reais.");


                Console.WriteLine("----------------------------------------");


                Console.WriteLine("Valor a ser guardado na poupança:" + valorPoupanca + " reais.");

                Console.WriteLine("----------------------------------------");

                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
