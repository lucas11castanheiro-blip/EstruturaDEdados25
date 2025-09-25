using System.Collections.Generic;

    
        Console.WriteLine("Invertendo palavaras com Stacks(Pilhas)");

        Stack<char> chars = new Stack<char>();

        foreach (var c in "Lucas")
        {
            chars.Push(c);
        }

        while (chars.Count > 0)
        {
            Console.Write(chars.Pop());
            Console.WriteLine();
        }
    
