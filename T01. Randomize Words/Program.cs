using System;
using System.Collections.Generic;
using System.Linq;

namespace T01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            Random random = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                string currentWord = words[i];
                int randomIndex = random.Next(0, words.Count);
                words[i] = words[randomIndex];
                words[randomIndex] = currentWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
