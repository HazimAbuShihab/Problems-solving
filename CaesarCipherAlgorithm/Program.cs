using System;
using System.Text;

namespace CaesarCipherAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Caesar Cipher";
            string encValue = Encrypt(input, 2);
            Console.WriteLine(encValue);
            Console.WriteLine(Decrypt(encValue, 2));
        }

        static string Encrypt(string input, int shift)
        {
            StringBuilder encryptedText = new StringBuilder();
            char[] arrOfChar = input.ToCharArray();
            foreach (char c in arrOfChar)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c))
                    {
                        encryptedText.Append((char)(((int)c + shift - 65) % 26 + 65)); // A = 65
                    }
                    else
                    {
                        encryptedText.Append((char)(((int)c + shift - 97) % 26 + 97)); // a = 97
                    }
                }
                else
                {
                    encryptedText.Append(c);
                }
            }
            return encryptedText.ToString();
        }

        static string Decrypt(string input, int shift)
        {
            StringBuilder decryptedText = new StringBuilder();
            char[] arrOfChar = input.ToCharArray();
            foreach (char c in arrOfChar)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c))
                    {
                        decryptedText.Append((char)(((int)c - shift - 65 + 26) % 26 + 65));
                    }
                    else
                    {
                        decryptedText.Append((char)(((int)c - shift - 97 + 26) % 26 + 97));
                    }
                }
                else
                {
                    decryptedText.Append(c);
                }
            }
            return decryptedText.ToString();
        }
    }
}
