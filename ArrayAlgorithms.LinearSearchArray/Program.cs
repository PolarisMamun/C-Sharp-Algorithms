using System;
using System.Linq;
using System.Threading.Channels;

namespace ArrayAlgorithms.LinearSearchArray
{
    //Linear Search or Sequential Search
    public class Program
    {
        static int? LinearSearch(int[] input,int n)
        {
            foreach(int current in input)
            {
                if (n == current)
                {
                    return n;
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            /*Console.WriteLine(LinearSearch(arr, 4));
            Console.WriteLine(LinearSearch(arr, 9));*/

            int item = Array.Find(arr, element => element == 4);
            Console.WriteLine(item);

            int[] items = Array.FindAll(arr, e => e >= 5).ToArray();

            Array.ForEach(items, Console.WriteLine);
        }
    }
}