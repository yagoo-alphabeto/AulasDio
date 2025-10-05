// Desafio
// Um número é azarado se contém um número 1 seguido por um 3 entre seus dígitos, ou seja, sempre que houver o caracteres "13", ele será considerado um número azarado. Por exemplo, o número 341329 é de má sorte, enquanto o número 12321 não é.
// Dado um inteiro N, seu programa terá que determinar se N é azarado ou não.
// Entrada
// A entrada consiste em um número positivo N (0 <= N <= 10¹⁷).
// Saída
// Imprima a mensagem "N es de Mala Suerte" se N é de má sorte, caso contrário imprima "N NO es de Mala Suerte".


// Para ler e escrever dados em C#, utilizamos os seguintes métodos da classe Console:
// - Console.ReadLine: lê UMA linha com dado(s) de Entrada (Inputs) do usuário;
// - Console.WriteLine: imprime um texto de Saída (Output) e pulando uma linha.

using System;

public class Program 
{
    public static void Main() 
    {
        string numero = Console.ReadLine();

        bool azarado = false;

        // Verifica se o número contém a sequência "13"
        for (int i = 0; i < numero.Length - 1; i++) 
        {
            if (numero[i] == '1' && numero[i + 1] == '3') 
            {
                azarado = true;
                break;
            }
        }

        // Imprime o resultado de acordo com a condição
        if (azarado)
            Console.WriteLine($"{numero} es de Mala Suerte");
        else
            Console.WriteLine($"{numero} NO es de Mala Suerte");
    }
}


