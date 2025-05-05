namespace CalcularVolumeCaixaRetangular.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                decimal resultado = 0;

                Console.WriteLine("--------------------------------");
                Console.WriteLine("Olá, vamos calcular o volume da sua caixa?");
                Console.WriteLine("--------------------------------");

                Console.WriteLine("Para começar, irei precisar das medidas de sua caixa:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Digite a medida do comprimento da caixa ");

                decimal comprimento = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Digite a medida do largura da caixa");

                decimal largura = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Digite a medida do altura da caixa");

                decimal altura = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("----------------------------------------");



                resultado = comprimento * largura * altura;


                Console.WriteLine("Obrigado pelos dados,o volume da sua caixa é : " + resultado.ToString("F2"));
                Console.ReadLine();
                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
