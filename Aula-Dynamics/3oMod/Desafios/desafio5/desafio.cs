using System;

class Program 
{
    static void Main(string[] args) 
    {
        int N = int.Parse(Console.ReadLine());
        int[] sequencia = new int[N];

        for (int i = 0; i < N; i++) 
        {
            sequencia[i] = int.Parse(Console.ReadLine());
        }

        int marcados = 0;

        // Começamos com o primeiro número marcado
        marcados++;

        // Iteramos pela sequência a partir do segundo número
        for (int i = 1; i < N; i++) 
        {
            // Se o número atual for diferente do anterior, podemos marcá-lo
            if (sequencia[i] != sequencia[i - 1]) 
            {
                marcados++;
            }
        }

        Console.WriteLine(marcados);
    }
}
