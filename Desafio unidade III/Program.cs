using System;

class Program
{
    static void Main()
    {
        // Array com 10 posições
        string[] vetor = new string[11];
        vetor[0] = " ";

        // Solicita os 10 valores do usuário
        Console.WriteLine("\n\tDigite 10 nomes ou números:\n\n");
        for (int i = 1; i < vetor.Length; i++)
        {
            Console.Write($"Posição {i}: ");
            vetor[i] = Console.ReadLine();

            if (vetor[i] == "Exit")

            {
                break;
            }

        }

        // Solicita entrada do usuário para busca
        Console.Write("\n\nDigite o nome ou número a ser pesquisado: ");
        string busca = Console.ReadLine();

        // Realiza a busca no vetor
        
        int posicao = Array.IndexOf(vetor, busca);

        // Exibe resultado
        if (posicao != -1)
        {
            Console.WriteLine($"\nEncontrado na posição: {posicao}");
        }
        else
        {
            Console.WriteLine("\nNão encontrado");
        }
    }
}