
    public class Program 
{
    public static void Main(string[] args) 
    {
        // Lê a linha de entrada
        string entrada = Console.ReadLine();

        // Divide a entrada em partes usando o espaço como delimitador
        string[] partes = entrada.Split(' ');

        // Converte as partes em inteiros
        int participantes = int.Parse(partes[0]);
        int cachorrosQuentes = int.Parse(partes[1]);

        // Calcula a média de cachorros-quentes consumidos por participante
        double media = (double) participantes / cachorrosQuentes;

        // Imprime a média com duas casas decimais
        Console.WriteLine($"{media:F2}");
    }
}