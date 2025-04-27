namespace CompararDecidirNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                decimal a, b, c;

                Console.WriteLine("Digite o valor de A: ");

                a = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite o valor de B: ");

                b = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite o valor de C: ");

                c = Convert.ToDecimal(Console.ReadLine());

                if (a + b < c)
                    Console.WriteLine("A soma de A e B é menor que C.");

                else

                    Console.WriteLine("A soma de A e B não é menor que C.");

                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
            


        }       
            

    }    
}
