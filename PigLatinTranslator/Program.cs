using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("igpay atinlay");
            Console.WriteLine("Enteryay ayay entencesay");
            Console.WriteLine("========================");

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            Console.Write(": ");
            string sentence = Console.ReadLine().ToLower();
            string[] words = sentence.Split(' ');

            string output = "";

            if (words.Count() != 0)
            {
                foreach (string word in words)
                {
                    if (!vowels.Contains(word.First()) && vowels.Contains(word.ElementAt(1)))
                    {
                        output += $"{word.Remove(0, 1)}{word.First()}ay ";
                    }
                    else if (!vowels.Contains(word.First()) && !vowels.Contains(word.ElementAt(1)))
                    {
                        output += $"{word.Remove(0, 1).Remove(0, 1)}{word.First()}{word.ElementAt(1)}ay ";
                    }
                    else if (vowels.Contains(word.First()))
                    {
                        output += $"{word}yay ";
                    }

                }
                Console.WriteLine(output); 
            }
            Console.ReadKey();
        }
    }
}
