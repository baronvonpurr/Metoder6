using System;

namespace Metod6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en mening");
            Console.WriteLine(convert(Console.ReadLine()));
        }

        static string convert(string sentence)
        {
            string[] words = sentence.Split(" ");
            sentence = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (i % 2 == 0)
                {
                    words[i] = words[i].ToUpper() + " ";
                }
                else
                {
                    words[i] = words[i].ToLower() + " ";
                }
                sentence = sentence + words[i];
            }
            return sentence;
        }
    }
}