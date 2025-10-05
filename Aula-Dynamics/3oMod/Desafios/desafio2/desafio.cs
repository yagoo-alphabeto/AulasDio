// Desafio
// Você deve fazer a leitura de 5 valores inteiros. Em seguida mostre quantos valores informados são pares, quantos valores informados são ímpares, quantos valores informados são positivos e quantos valores informados são negativos. Considere que o número zero é positivo, mas não pode ser considerado como positivo ou negativo.
// Entrada
// Você receberá 5 valores inteiros.
// Saída
// Exiba a mensagem conforme o exemplo de saída abaixo, sendo uma mensagem por linha e não esquecendo o final de linha após cada uma.


// Para ler e escrever dados em C#, utilizamos os seguintes métodos da classe Console:
// - Console.ReadLine: lê UMA linha com dado(s) de Entrada (Inputs) do usuário;
// - Console.WriteLine: imprime um texto de Saída (Output) e pulando uma linha.

using System;

namespace Program 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int valor3 = int.Parse(Console.ReadLine());
            int valor4 = int.Parse(Console.ReadLine());
            int valor5 = int.Parse(Console.ReadLine());

            int quantidadePares = 0;
            int quantidadeImpares = 0;
            int quantidadePositivos = 0;
            int quantidadeNegativos = 0;

            // Verificando se os valores são pares ou ímpares
            if (valor1 % 2 == 0) 
                quantidadePares++;
            else
                quantidadeImpares++;

            if (valor2 % 2 == 0) 
                quantidadePares++;
            else
                quantidadeImpares++;

            if (valor3 % 2 == 0) 
                quantidadePares++;
            else
                quantidadeImpares++;

            if (valor4 % 2 == 0) 
                quantidadePares++;
            else
                quantidadeImpares++;

            if (valor5 % 2 == 0) 
                quantidadePares++;
            else
                quantidadeImpares++;

            // Verificando se os valores são positivos, negativos ou zero
            if (valor1 > 0) 
                quantidadePositivos++;
            else if (valor1 < 0)
                quantidadeNegativos++;

            if (valor2 > 0) 
                quantidadePositivos++;
            else if (valor2 < 0)
                quantidadeNegativos++;

            if (valor3 > 0) 
                quantidadePositivos++;
            else if (valor3 < 0)
                quantidadeNegativos++;

            if (valor4 > 0) 
                quantidadePositivos++;
            else if (valor4 < 0)
                quantidadeNegativos++;

            if (valor5 > 0) 
                quantidadePositivos++;
            else if (valor5 < 0)
                quantidadeNegativos++;

            Console.WriteLine($"{quantidadePares} par(es)");
            Console.WriteLine($"{quantidadeImpares} impar(es)");
            Console.WriteLine($"{quantidadePositivos} positivo(s)");
            Console.WriteLine($"{quantidadeNegativos} negativo(s)");
        }
    }
}
