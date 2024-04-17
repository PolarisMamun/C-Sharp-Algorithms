using System;

namespace StringAlgorithms.NormalizeString
{
    public class Program
    {
        static string NormalizeString(String input)
        {
            /*string lowercased = input.ToLower();
            string trimmed = lowercased.Trim();
            return trimmed.Replace(",", "");*/

            //can do refactor above code
            return input.ToLower().Trim().Replace(",","");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(NormalizeString(" Hello There, BUDDY      "));
        }
    }
}
