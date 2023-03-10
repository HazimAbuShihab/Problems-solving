using System;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace WriteOnTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WriteOnText("Hello World", "TestFile");
        }
        private static void WriteOnText(string sentence,string fileName)
        {
            using (StreamWriter writer = new StreamWriter("../"+fileName, true))
            {
                writer.WriteLine(DateTime.Now.ToString("dd/MM/yyyy hh:mm"));
                writer.WriteLine(sentence);
            }
        }
    }
}