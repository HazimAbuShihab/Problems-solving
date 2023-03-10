using System;

namespace Longestword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "fun&!! time";
            Console.WriteLine(LongestWord(input));
        }
        static string LongestWord(string sentence)
        {
            string[] arrOfWords = sentence.Split(new char[] {' ', ',', ';', '.', '!', '?', '&', '|' }, StringSplitOptions.RemoveEmptyEntries);
            string longestWord = "";
            foreach (string word in arrOfWords)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            return longestWord;
        }
    }
}
