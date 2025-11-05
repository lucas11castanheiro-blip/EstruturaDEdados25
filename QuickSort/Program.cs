using System;
using QuickSort_Model;
class Program
{
    static void Main(string[] args)
    {
        int[] array = { 34, 7, 23, 32, 5, 62 };
        Console.WriteLine("Array original:");
        Console.WriteLine(string.Join(", ", array)); // Correctly display the array

        QuickSort.QuickSortClass.Sort<int>(array, 0, array.Length - 1);

        // OBS: existe também a sobrecarga que ordena todo o array diretamente:
        QuickSort.QuickSortClass.Sort(array);

        Console.WriteLine("\n");

        Console.WriteLine("Array ordenado:");
        Console.WriteLine(string.Join(", ", array));
    }
}