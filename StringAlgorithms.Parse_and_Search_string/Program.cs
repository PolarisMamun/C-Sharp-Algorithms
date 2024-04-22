using System;

namespace StringAlgorithms.Parse_and_Search_string
{
    public class Program
    {
        static void ParseContents(string s)
        {
            Console.WriteLine("Option 1");
            foreach(char c in s)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Option 2");

            for(int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                Console.WriteLine(c);
            }
        }

        static Boolean IsAtEvenIndex(string s, char item)
        {
            if(string.IsNullOrEmpty(s)) return false;

            for(int i = 0; i <s.Length /2+1; i = i + 2)
            {
                if (s[i] == item)
                {
                    return true;
                }
            }
            return false;
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ParseContents("Hello World!");

            string input = "Hello";
            Console.WriteLine(IsAtEvenIndex(input,'H'));
            Console.WriteLine(IsAtEvenIndex(input,'T'));
            Console.WriteLine(IsAtEvenIndex(input,'o'));
            Console.WriteLine(IsAtEvenIndex(input,'s'));
            Console.WriteLine(IsAtEvenIndex("",'L'));
            Console.WriteLine(IsAtEvenIndex(null,'L'));

            Console.ReadLine();
        }
    }
}
