using System;

namespace SortUtility
{
    public class Algorithm
    {
        public static void MergeSort(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            MergeSort(array, 0, array.Length - 1);
        }
        
        private static void MergeSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int middle = (low + high) / 2;
                MergeSort(array, low, middle);
                MergeSort(array, middle + 1, high);

                int[] buf = new int[array.Length];
                for (int i = low; i <= high ; i++)
                {
                    buf[i] = array[i];
                }
                int indexLeft = low;
                int indexRight = middle + 1;
                int current = low;

                while (indexLeft <= middle && indexRight <= high)
                {
                    if (buf[indexLeft] <= buf[indexRight])
                    {
                        array[current] = buf[indexLeft];
                        indexLeft++;
                    }
                    else
                    {
                        array[current] = buf[indexRight];
                        indexRight++;
                    }
                    current++;
                }

                int remaining = middle - indexLeft;

                for (int i = 0; i <= remaining; i++)
                {
                    array[current + i] = buf[indexLeft + i];
                }
            }
        }
    }
}