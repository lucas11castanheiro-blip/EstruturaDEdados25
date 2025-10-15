using Bubble_Sort;
Console.WriteLine("Ordenação com Bubble Sort");

int[] arrNumbers = new int[] { 
    99, 50 , -24 , 0 , 1
};

foreach (var number in arrNumbers)
{
    Console.Write($" [{number}] ");
}

Console.WriteLine("\n\n\t-/-/-/-/-/-/-/-/-/-/-/");
Console.WriteLine("\n\tORDENADO\n");

var arrOrdered = BubbleSortOrder.Sort<int>(arrNumbers);

foreach (var number in arrOrdered)
{
    Console.WriteLine($" [{number}] ");
}
Console.WriteLine("\n\t-/-/-/-/-/-/-/-/-/-/-/");
