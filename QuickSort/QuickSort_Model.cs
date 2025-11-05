using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSort_Model
{
    public class QuickSort
    {
        public static class QuickSortClass
        {
            public static void Sort<T>(T[] array) where T : IComparable
            {
                Sort(array, 0, array.Length - 1); // para percorrer até o penúltimo elemento
            }

            public static void Sort<T>(T[] array, int lower, int upper) where T : IComparable
            {
                if (lower < upper)
                {
                    int p = Partition(array, lower, upper);
                    Sort(array, lower, p - 1);
                    Sort(array, p + 1, upper);
                }
            }

            private static int Partition<T>(
                T[] array,
                int lower,
                int upper
            ) where T : IComparable
            {
                T pivot = array[lower];
                int i = lower - 1;
                int j = upper + 1;

                while (true)
                {
                    do { i++; } while (array[i].CompareTo(pivot) < 0);
                    do { j--; } while (array[j].CompareTo(pivot) > 0);
                    if (i >= j)
                        return j;
                    Swap(array, i, j);
                }
            }

            private static void Swap<T>(T[] array, int i, int j)
            {
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}