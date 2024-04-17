using System;
using System.Linq;

namespace StringAlgorithms.ValidateString
{
    public class Program
    {
        static Boolean IsUpperCase(string s)
        {
            /*if (s.All(char.IsUpper))
            {
                return true;
            }
            else 
            {
                return false; 
            }*/

            //We can do all above code in single Line

            return s.All(char.IsUpper);
            /*The 'All' method is a LINQ method that determines whether all elements in a sequence satisfy a condition. The method takes a predicate function as an argument, which is a function that takes an element from the sequence as an argument and returns a Boolean value indicating whether the element satisfies the condition.*/
        }
        static Boolean IsLowerCase(string s)
        {
            return s.All(char.IsLower);
        }
        static Boolean IsPasswordComplex(string s)
        {
            return s.Any(char.IsUpper) 
                && s.Any(char.IsLower) 
                && s.Any(char.IsDigit);
        }
        static void Main(string[] args)
        {
            /*Console.WriteLine(IsUpperCase("hello"));
            Console.WriteLine(IsUpperCase("HELLO"));
            Console.WriteLine(IsUpperCase("hello"));
            Console.WriteLine(IsUpperCase("HELLO"));*/

            Console.WriteLine(IsPasswordComplex("HElL0"));
            Console.WriteLine(IsPasswordComplex("HELL0"));
            Console.WriteLine(IsPasswordComplex("HELLO"));
            Console.WriteLine(IsPasswordComplex("hello"));
            Console.WriteLine(IsPasswordComplex(" "));

        }
    }
}
