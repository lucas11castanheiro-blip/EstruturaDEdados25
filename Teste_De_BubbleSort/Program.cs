using System;
using Atividade_BubbleSort;

Console.WriteLine("\tOrdenação com Bubble Sort\n");

Console.Write("Quantos nomes você deseja inserir? ");
int n = Convert.ToInt32(Console.ReadLine());

string[]? names = new string[n];


    for (int i = 0; i < names.Length; i++)
    {
        Console.Write($"Digite o {i + 1}º nome: ");
        names[i] = Console.ReadLine();
    }

Console.WriteLine("\n\tNomes ordenados de forma crescente: ");
Console.WriteLine("\n");
    string[]? namesc = BubbleSort.Sort(names);
    
    foreach (var i in namesc)
    {
        Console.WriteLine(i);
    }

Console.WriteLine("\n\tNomes ordenados de forma decrescente: ");
Console.WriteLine("\n");

    string[]? namesd = BubbleSortD.Sort(names);

    foreach (var i in namesd)
    {
        Console.WriteLine(i);
    }
    
    Console.WriteLine("\n\nPressione qualquer tecla para sair.");
    Console.ReadKey();
