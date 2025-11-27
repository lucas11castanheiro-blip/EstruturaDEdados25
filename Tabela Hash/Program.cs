using System;
using System.Collections;   

Hashtable phoneBook = new Hashtable()
    {
        { "Marcin Jamro", "000-000-000" },
        { "John Smith", "111-111-111" }
    };

phoneBook["Lily Smith"] = "333-333-333";

try
    {
        phoneBook.Add("Mary Fox", "222-222-222");
    }
catch (ArgumentException)
    {
        Console.WriteLine("A entrada já existe.");
    }

Console.WriteLine("\n\n\tNúmeros de telefone: \n'");

if (phoneBook.Count == 0)
    {
    Console.WriteLine("Vazio");
    }
else
    {
        foreach (DictionaryEntry entry in phoneBook)
        {
            Console.WriteLine($" - {entry.Key}: {entry.Value}");
        }
    }

Console.WriteLine();

Console.Write("\n\nProcure pelo nome: ");

string name = Console.ReadLine();

if (phoneBook.Contains(name))
    {
        string number = (string)phoneBook[name];
        Console.WriteLine($"\nNúmero Encontrado: {number}");
    }
else
    {
        Console.WriteLine("Entrada não encontrada.");
    }

