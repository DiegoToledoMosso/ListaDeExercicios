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
                Console.WriteLine("Olá, somos a imobiliária Imóbilis, aqui iremos calcular área do seu terreno");
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Para começar, irei precisar medidas do seu terreno:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Digite a largura do terreno em metros:");


                double terrenoLargura = Double.Parse(Console.ReadLine());

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Digite o comprimento do terreno em metros:");


                double terrenoComprimento = Double.Parse(Console.ReadLine());

                Console.WriteLine("----------------------------------------");

                if (terrenoLargura == terrenoComprimento)
                {
                    Console.WriteLine("Não vendemos terrenos que não seja retangular!!");

                }
                else
                {
                    double area = terrenoLargura * terrenoComprimento;
                    Console.WriteLine($"A área do terreno é: {area}metros quadrados.");
                }


                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
