namespace IdadeEmDias.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Olá, Bem-vindo a calculadora de idade em dias. ");
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Para começar, irei precisar saber sua idade:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Digite a quantos anos você tem:");

                
                double idade = Double.Parse(Console.ReadLine());


                double dias = idade * 365;


                Console.WriteLine($"Obrigado pela informação, a sua idade em dias é de : {dias} dias de idade." );


                Console.WriteLine("----------------------------------------");

                
                

                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
