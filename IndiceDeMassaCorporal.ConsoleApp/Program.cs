namespace IndiceDeMassaCorporal.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)

            {
                Console.WriteLine("Digite seu peso em kg:");

                decimal peso = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite sua altura em metros:");

                decimal altura = Convert.ToDecimal(Console.ReadLine());

                decimal imc = peso / (altura * altura);

                Console.WriteLine("Seu IMC é: " + imc);

                if (imc < 18.5m)

                {

                    Console.WriteLine("De acordo com a Organização Mundial de Saúde você esta abaixo do peso");

                }

                else if (imc < 25)

                {

                    Console.WriteLine("De acordo com a Organização Mundial de Saúde você esta com o peso normal");

                }

                else if (imc < 30)

                {

                    Console.WriteLine("De acordo com a Organização Mundial de Saúde você esta acima do peso");

                }
                else
                {

                    Console.WriteLine("De acordo com a Organização Mundial de Saúde você esta obeso");

                }

                Console.ReadLine();

                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
