using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraSimples
{
    partial class Program
    {
        static void RealizarOperacao(int operacao, double valorUm, double valorDois)
        {
            if (operacao == 1)
            {
                Somar(valorUm, valorDois);
            }

            if (operacao == 2)
            {
                Subtrair(valorUm, valorDois);
            }

            if (operacao == 3)
            {
                Multiplicar(valorUm, valorDois);
            }

            if (operacao == 4)
            {
                Dividir(valorUm, valorDois);
            }
        }

        static double Somar(double valorUm, double valorDois)
        {
            var resultado = valorUm + valorDois;
            Console.WriteLine($"A soma entre {valorUm} e {valorDois} é: {resultado}");
            return resultado;
        }

        static double Subtrair(double valorUm, double valorDois)
        {
            var resultado = valorUm - valorDois;
            Console.WriteLine($"A subtração entre {valorUm} e {valorDois} é: {resultado}");
            return resultado;
        }

        static double Multiplicar(double valorUm, double valorDois)
        {
            var resultado = valorUm * valorDois;
            Console.WriteLine($"A multiplicação entre {valorUm} e {valorDois} é: {resultado}");
            return resultado;
        }

        static double Dividir(double valorUm, double valorDois)
        {
            if (valorDois == 0)
            {
                throw new DivideByZeroException($"Impossível dividir por zero!!! {valorUm} / {valorDois} Não é possível...");
            }
            var resultado = valorUm / valorDois;
            Console.WriteLine($"A divisão entre {valorUm} e {valorDois} é: {resultado}");
            return resultado;
        }
    }
}
