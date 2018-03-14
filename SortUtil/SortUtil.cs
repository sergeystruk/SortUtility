using System;

namespace SortUtils
{
    /// <summary>
    /// Class which provides methods for merge sort and quick sort
    /// </summary>
    public static class Algorithm
    {
        #region API
        /// <summary>
        /// Uses merge sort for array
        /// </summary>
        /// <param name="array">
        /// The array needed to be sorted
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Throws when "array" parameter is null
        /// </exception>
        public static void MergeSort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            MergeSort(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Uses quick sort for array
        /// </summary>
        /// <param name="array">
        /// The array needed to be sorted
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Throws when "array" parameter is null
        /// </exception>
        public static void QuickSort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            QuickSort(array, 0, array.Length - 1);
        }

        #endregion

        #region Logic

        /// <summary>
        /// Uses merge sort for part of array lying between "low" and "high"
        /// </summary>
        /// <param name="array">
        /// The array needed to be sorted
        /// </param>
        /// <param name="low">
        /// Lower border of array
        /// </param>
        /// <param name="high">
        /// Higher border of array
        /// </param>
        private static void MergeSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int middle = (low + high) / 2;
                MergeSort(array, low, middle);
                MergeSort(array, middle + 1, high);

                int[] buf = new int[array.Length];
                for (int i = low; i <= high; i++)
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

        /// <summary>
        /// Method separates elements which are smaller than separator with elements which are bigger 
        /// </summary>
        /// <param name="array">
        /// The array needed to be sorted
        /// </param>
        /// <param name="start">
        /// Higher border of array
        /// </param>
        /// <param name="end">
        /// Lower border of array
        /// </param>
        /// <remarks>
        /// Last element is used as separator
        /// </remarks>
        /// <returns>
        /// Index of separator in array
        /// </returns>
        private static int Separation(int[] array, int start, int end)
        {
            int buffer;
            int separatorIndex = start;

            for (int i = start; i <= end; i++)
            {
                if (array[i] < array[end])
                {
                    buffer = array[separatorIndex];
                    array[separatorIndex] = array[i];
                    array[i] = buffer;
                    separatorIndex++;
                }
            }

            buffer = array[separatorIndex];
            array[separatorIndex] = array[end];
            array[end] = buffer;
            return separatorIndex;
        }

        /// <summary>
        /// Uses quick sort for part of array lying between "start" and "end"
        /// </summary>
        /// <param name="array">
        /// The array needed to be sorted
        /// </param>
        /// <param name="start">
        /// Higher border of array
        /// </param>
        /// <param name="end">
        /// Lower border of array
        /// </param>
        private static void QuickSort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int separator = Separation(array, start, end);
            QuickSort(array, start, separator - 1);
            QuickSort(array, separator + 1, end);
        }

        #endregion
    }
}