namespace CalcularMediaHarmonica.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Solicitar ao utilizador para introduzir as notas
                Console.WriteLine("Introduza as notas do aluno (separadas por espaço):");
                string notasString = Console.ReadLine();

                // Converter a string de notas em um array de double
                string[] notasArray = notasString.Split(' ');
                double[] notas = new double[notasArray.Length];


                for (int i = 0; i < notasArray.Length; i++)
                {
                    if (double.TryParse(notasArray[i], out notas[i]))
                    {
                        // Nota válida
                    }
                    else
                    {
                        Console.WriteLine($"Erro: A nota {notasArray[i]} é inválida.");
                        return; // Terminar o programa se houver um erro na entrada
                    }
                }

                // Calcular a média harmónica
                double somaInversa = 0;
                foreach (double nota in notas)
                {
                    somaInversa += 1 / nota;
                }

                double mediaHarmonica = notas.Length / somaInversa;

                // Mostrar a média harmónica
                Console.WriteLine($"A média harmónica das notas é: {mediaHarmonica}");
                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
