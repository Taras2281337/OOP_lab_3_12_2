using System;
using System.IO;

namespace OOP_lab_3_12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("text.txt");

            string text = file.ReadToEnd();

            string[] str = text.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

            text = "";

            foreach (string s in str)
            {
                text += s + " ";
            }

            string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Console.Write("Ключове слово: ");

            string keyWord = Console.ReadLine();

            Console.WriteLine("\nРечення, що мiстять ключове слово:");

            for (int i = 0; i < sentences.Length; ++i)
            {
                string[] words = sentences[i].Split(new char[] { '\n', '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (word == keyWord)
                    {
                        Console.WriteLine("{0}.", sentences[i]);
                        break;
                    }
                }
            }
        }
    }
}
