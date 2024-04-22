using System;

namespace ArrayAlgorithms.BinarySearch
{
    public class Program
    {
        static Boolean BinarySearch(int[] inputArray,int item)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if(item == inputArray[mid])
                {
                    //Console.WriteLine(item);
                    return true;
                }
                else if(item < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                { 
                    min = max + 1;
                }
            }//ArrayAlgorithms.AggregateAndFilter arrays
            return false;
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 6, 7, 13, 30, 35, 40, 47, 48, 70 };
            int item = 13;
            //BinarySearch(arr, item);
            int binary = Array.BinarySearch(arr, 13);
            Console.WriteLine(binary);
        }
    }
}
