namespace AumentoDeSalario.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Olá, Aqui iremos ver como irá ficar seu salário com o aumento de 15%.");
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Para começar, irei precisar saber do seu salário atual:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Digite o seu salário atual:");


                decimal salario = Convert.ToDecimal(Console.ReadLine());


                decimal salarioAumentado = salario * 1.15m;

                decimal salarioDescontado = salarioAumentado * 0.08m;

                decimal salarioFinal = salarioAumentado - salarioDescontado;


                Console.WriteLine($"Obrigado pela informação, o seu salário inicial foi de : {salario} reais.");

                Console.WriteLine($"Obrigado pela informação, o seu salário com o aumento de 15% foi de : {salarioAumentado} reais.");

                Console.WriteLine($"Obrigado pela informação, o seu salário final depois de descontar os impostos de 8% foi de : {salarioFinal} reais.");


                Console.WriteLine("----------------------------------------");




                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
