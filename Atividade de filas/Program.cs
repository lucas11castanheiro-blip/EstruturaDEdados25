using System;
using System.Collections.Generic;



Console.WriteLine("\n\n\tTeste de palíndromo");
Console.Write("Digite uma palavra: ");
string? palavra = Console.ReadLine();

Stack<char> chars = new Stack<char>();

        foreach (var c in palavra)
        {
            chars.Push(c);
        }

        string invertida = "";
        while (chars.Count > 0)
        {
            invertida += chars.Pop();
        }

        if (palavra.Equals(invertida, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("É um palíndromo!");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo.");
        }
