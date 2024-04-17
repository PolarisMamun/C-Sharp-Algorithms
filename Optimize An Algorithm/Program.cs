using System;

namespace Optimize_An_Algorithm
{
    public class Program
    {
        static int FindMaximum(int a, int b,int c)
        {
            if (a > b)
            {
                if(a > c || a == c)
                {
                    return a;
                }
            }
            if(b > c)
            {
                if(b > c || b == c)
                {
                    return b;
                }
            }
            return c;
        }

        static int FindMaximum2(int a, int b,int c)
        {
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if(c > max)
            {
                max = c;
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindMaximum2(1,2,3));
            Console.WriteLine(FindMaximum2(8,8,1));
            Console.WriteLine(FindMaximum2(3,2,3));
            Console.WriteLine(FindMaximum2(1,1,9));
            Console.WriteLine(FindMaximum2(1,9,9));

            Console.ReadLine();
        }
    }
}
