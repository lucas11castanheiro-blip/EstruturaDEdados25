using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Atividade_BubbleSort
{
    public class BubbleSort
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
            if (lower < upper)
            {
                int p = Partition(array, lower, upper);
                Sort(array, lower, p);
                Sort(array, p + 1, upper);
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

            do
            {
                while (array[i].CompareTo(pivot) < 0) { i++; }
                while (array[j].CompareTo(pivot) > 0) { j--; }
                while (i <= j) { break; }
                Swap(array, i, j);

            }
            while (i <= j);
                return j;
            }
        }
    }
}