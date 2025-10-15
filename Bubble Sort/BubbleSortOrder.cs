using System;

namespace Bubble_Sort
{
    public class BubbleSortOrder
    {
        
        public static T[] Sort<T>(T[] array)
            where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
            return array;
        }

        private static void Swap<T>(
            T[] array,
            int firstIndex,
            int secondIndex
        )
        {
            (array[firstIndex], array[secondIndex]) = (array[secondIndex], array[firstIndex]);
        }
    }
}