using System;

namespace CalculadoraCsharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Menu();
        }
            static void Menu ()
        {
            Console.Clear();

            Console.WriteLine("Bem vindo a calculadora CSharp, escolha uma opção.");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair do programa");

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Selecione uma opção: ");
            // Esta linha lê uma entrada do usuário, que deve ser um número, e a converte para um tipo short.
            short res = short.Parse(Console.ReadLine());

            switch (res) {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                    default: Menu(); break;
            }


        }
            static void Soma()
            {
                Console.Clear();

                Console.Write("Primeiro Valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.Write("Segundo Valor: ");
                float v2 = float.Parse(Console.ReadLine());
                float resultado = v1 + v2;

                Console.WriteLine($"Resultado da soma: {resultado}");
                
                Console.ReadKey();  
                Menu();
            }

            static void Subtracao()
        {
            Console.Clear();

            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            Console.Write($"O resultado da subitração é {resultado}");

            Console.ReadKey();
            Menu();
        }

            static void Divisao()
        {
            Console.Clear();

            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            Console.Write($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }

            static void Multiplicacao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.Write($"O Resultado da Multiplicação é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}