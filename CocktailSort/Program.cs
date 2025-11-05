using System;

public class CocktailSortExample
{
    // Ordena o vetor em ordem crescente usando Cocktail Sort (ida e volta).

    public static void CocktailSort(int[] array)
    {
        bool swapped = true; int start = 0, end = array.Length - 1; 
        while (swapped) // repete enquanto houver trocas na iteração
        {
            swapped = false; // inicia a ida assumindo que não possui trocas
            for (int i = start; i < end; i++) 
            {
                if (array[i] > array[i + 1]) { (array[i], array[i + 1]) = (array[i + 1], array[i]); swapped = true; } // ida: empurra o maior para 'final'
            }
            if (!swapped) break; // sem trocas na ida: já está ordenado
            end--; swapped = false; // reduz limite direito e prepara a volta
            for (int i = end - 1; i >= start; i--) 
            {
                if (array[i] > array[i + 1]) { (array[i], array[i + 1]) = (array[i + 1], array[i]); swapped = true; } // volta: traz o menor para 'inicio'
            }
            start++; // avança limite esquerdo
        }
    }


    public static void Main()
    {
        // entrada de dados
        int[] data = { 5, 3, 8, 4, 2, 7, 1, 9 }; // vetor inicial

        //vetor antes da ordenação.
        Console.WriteLine("Antes da ordenação: " + string.Join(", ", data)); // imprime estado inicial

        // Chamada para ordenação.
        CocktailSort(data); 

        // vetor após a ordenação para verificação de corretude.
        Console.WriteLine("Depois da ordenação: " + string.Join(", ", data)); // imprime estado final
    }
}