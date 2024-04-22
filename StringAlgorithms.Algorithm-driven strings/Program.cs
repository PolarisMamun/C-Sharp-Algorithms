using System;
using System.Linq;
using System.Text;

namespace StringAlgorithms.Algorithm_driven_strings
{
    public class Program
    {
        static string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;//This line checks if the input string is either null or empty. If it is, the method returns the input string as it is, since reversing an empty or null string would result in the same string.

            StringBuilder reversed = new StringBuilder(); //StringBuilder is used here because it provides efficient string manipulation operations.

            for (int i = input.Length - 1; i >= 0; i--) //This line starts a for loop that iterates over each character of the input string in reverse order. It starts from the last character (input.Length - 1) and goes backwards until the first character (0).
            {
                reversed.Append(input[i]);
            }
            return reversed.ToString();
        }

        static string Reverse2(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            char[] arr = input.ToCharArray();//This line converts the input string into an array of characters using the ToCharArray() method. This is done to make it easier to manipulate the characters in the string.
            Array.Reverse(arr);//This line reverses the order of elements in the character array arr using the Reverse method of the Array class.

            return new string(arr);//a new string is created using the reversed character array arr, and it is returned from the method. The new string(char[]) constructor is used to construct a string from an array of characters.
        }
        static string ReverseTest(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            string reversedWord = new string(arr);
            return reversedWord;
        }

        static string ReverseEachWord(string sentence)
        {
            string[] words = sentence.Split(' ');
            string[] reversedWords = words.Select(ReverseTest).ToArray();
            string joinSentence = string.Join(" ", reversedWords);
            return joinSentence;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseEachWord("Hello World!"));
            Console.WriteLine(Reverse("Hello"));
            Console.WriteLine(Reverse("World!"));
            Console.WriteLine(Reverse("Mamun"));
            Console.WriteLine(Reverse(null));
            Console.WriteLine("=======================");
            Console.WriteLine(Reverse2("Hello World!"));
            Console.WriteLine(Reverse2("Hello"));
            Console.WriteLine(Reverse2("World!"));
            Console.WriteLine(Reverse2("Mamun"));
            Console.WriteLine(Reverse2(null));
        }
    }
}
