using System;

namespace CalculosFlavianos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("\n 4X4 CALCULEITORS \n");

                int resultado;

                Console.Write("Digite um número: ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite outro número: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Escolha uma operação: ");
                Console.Write("1- soma\t \t | \t");
                Console.WriteLine("2- subtração:\t ");
                Console.Write("3- divisão \t | \t");
                Console.WriteLine("4- multiplicação ");
                Console.Write("Digite sua escolha: ");
                int opçao = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine();



                if (opçao == 1)
                {
                    resultado = n1 + n2;
                    Console.WriteLine("o resultado da soma " + n1 + " + " + n2 + " é igual a " + resultado);
                }
                else if (opçao == 2)
                {
                    resultado = n1 - n2;
                    Console.WriteLine("o resultado da subtração " + n1 + " - " + n2 + " é igual a " + resultado);
                }
                else if (opçao == 3)
                {
                    resultado = n1 / n2;
                    Console.WriteLine("o resultado da divisão " + n1 + " / " + n2 + " é igual a " + resultado);
                }
                else if (opçao == 4)
                {
                    resultado = n1 * n2;
                    Console.WriteLine("o resultado da multiplicação " + n1 + " * " + n2 + " é igual a " + resultado);
                }
                else
                {
                    Console.WriteLine("Operação inválida, leia o manual e tente novamente.");
                }
                Console.WriteLine();

                Console.WriteLine("Deseja realizar mais uma operação?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");
                Console.Write("Digite o número de sua escolha:");

                int opçaoContinuar = Convert.ToInt16(Console.ReadLine());
                if( opçaoContinuar != 1)
                {
                    break;
                }
                Console.WriteLine("\n--------------------------------------------\n");
                
            }
            Console.WriteLine("\n ------ Finalizado, obrigado volte sempre! ------ \n ");
        }
    }
}
