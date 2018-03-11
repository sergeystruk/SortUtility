using System;
using SortUtility;

namespace SortTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 14, 2, 3, 7, -1, 8, -12, 10, 20, 15, 3, -10, 100 };

            Console.WriteLine("Initial array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}, ", arr[i]);
            }
            Console.WriteLine();

            Algorithm.MergeSort(arr);

            Console.WriteLine();
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}, ", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
