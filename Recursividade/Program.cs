Console.Write("Entre com o da tamnho da série de Fibonacci: ");

string? input = Console.ReadLine();

int lenght = 0;

if (!Int32.TryParse(input, out lenght) )
{
    Console.WriteLine("Número inválido.");
    return;
}

for (int i = 0; i < lenght; i++)
{
    Console.Write(" {0} ", FibonacciSeries(i));
}
Console.ReadKey();

static int FibonacciSeries(int n)
{
    if (n == 0) return 0; // para retonar o primeiro elemento da série de Fibonnaci
    if (n == 1) return 1; // para retonar o segundo elemento da série de Fibonnaci
    return FibonacciSeries(n - 2) + FibonacciSeries(n - 1);
}


