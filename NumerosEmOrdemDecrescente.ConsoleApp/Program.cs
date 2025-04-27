using System;

namespace NumerosEmOrdemDecrescente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Digite três valores inteiros e diferentes: ");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Digite o primeiro valor");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Digite o segundo valor");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Digite o terceiro valor");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("Os valores em ordem decrescente são: ");
                    Console.WriteLine(a + ", " + b + ", " + c);
                }                                                 

                else
                {
                    Console.WriteLine("Os valores em ordem decrescente são: ");
                    Console.WriteLine(a + ", " + c + ", " + b);
                }

                                 

            }

            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("Os valores em ordem decrescente são: ");
                    Console.WriteLine(b + ", " + a + ", " + c);
                }
                                                           

                else
                {
                    Console.WriteLine("Os valores em ordem decrescente são: ");
                    Console.WriteLine(b + ", " + c + ", " + a);
                }                                      

            }

            else

            {

                if (a > b)
                {
                    Console.WriteLine("Os valores em ordem decrescente são: ");
                    Console.WriteLine(c + ", " + a + ", " + b);
                }                                      
                
                else
                {
                    Console.WriteLine("Os valores em ordem decrescente são: ");
                    Console.WriteLine(c + ", " + b + ", " + a);
                }
                                 

            }

            Console.ReadLine();

        }

    }        
    
}
