using System;

namespace CalculadoraSimples
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var continuar = "s";

            while (continuar == "s")
            {
                Console.Clear();

                Console.WriteLine("------ Calculadora Simples ------");
                Console.WriteLine();

                Console.Write("Digite o primeiro valor: ");
                var primeiroValor = Console.ReadLine();
                double primeiroValorDouble;
                if (!double.TryParse(primeiroValor, out primeiroValorDouble))
                {
                    Console.WriteLine("O valor que você acabou de digitar não foi aceito. O programa irá entender como zero!!!");
                    Console.WriteLine();
                }

                Console.Write("Digite o segundo valor: ");
                var segundoValor = Console.ReadLine();
                double segundoValorDouble;
                if (!double.TryParse(segundoValor, out segundoValorDouble))
                {
                    Console.WriteLine("O valor que você acabou de digitar não foi aceito. O programa irá entender como zero!!!");
                    Console.WriteLine();
                }

                Console.Write("Digite (1) para Somar, (2) para Subtrair, (3) para Multiplicar ou (4) para Dividir: ");
                var operacao = Console.ReadLine();
                var operacaoInt = int.Parse(operacao);
                Console.WriteLine();

                try
                {
                    RealizarOperacao(operacaoInt, primeiroValorDouble, segundoValorDouble);
                }
                catch (DivideByZeroException ex)
                {

                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine();
                Console.Write("Digite (s) para realizar outra conta ou qualquer outra tecla para sair: ");
                continuar = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("Aplicação finalizada. Pressione qualquer tecla para sair...");

            Console.ReadKey();
        }
    }
}
