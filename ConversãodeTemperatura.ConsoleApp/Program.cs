namespace ConversãodeTemperatura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                decimal c = 0;

                decimal resultado = 0;

                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Olá, aqui iremos converter graus Celsius (°C) para graus Fahrenheit (°F)");
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Para começar, irei precisar da temperatura em graus Celcius (°C) ");
                Console.WriteLine("----------------------------------------");

                c = Convert.ToDecimal(Console.ReadLine());

                resultado = (c * 9 / 5) + 32;

                Console.WriteLine($"A temperatura é de {resultado} graus Fahrenheit (°F).");

                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;


            }
        }
    }
}