//obs: Utilizando estrutura repetitiva For:
//Problema "divisao" (adaptado de URI 1116)
//Escreva um algoritmo que leia dois números e imprima o resultado da divisão do primeiro pelo
//segundo. Caso não for possível, mostre a mensagem “DIVISAO IMPOSSIVEL”. 

using System.Globalization;

namespace DivisaoEstruturaRepetitiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, numerador, denominador;
            double divisao;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos casos serão digitados? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o numerador: ");
                numerador = int.Parse(Console.ReadLine());

                Console.Write("Digite o denominador: ");
                denominador = int.Parse(Console.ReadLine());


                if (denominador == 0)
                {
                    Console.WriteLine("DIVISAO IMPOSSIVEL");
                }
                else
                {
                    divisao = (double)numerador / denominador;
                    Console.WriteLine($"DIVISAO = {divisao.ToString("F2", CI)}");
                }
            }
        }
    }
}