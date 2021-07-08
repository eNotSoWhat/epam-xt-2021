using System;
using System.Collections.Generic;
using System.Linq;

namespace textAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            char[] symbols = new char[] { ' ', ';', ',', ':', '.', '!', '?', '-', '"' };
            Console.WriteLine("Insert text:");
            string txt = Console.ReadLine();
            string[] arr = txt.Split(symbols);
            for (int i = 0; i < arr.Length; i++)
            {
                if (words.Count == 0)
                    words.Add(arr[i].ToLower(), 1);
                else if (arr[i] != String.Empty)
                {
                    if (!words.ContainsKey(arr[i].ToLower()))
                        words.Add(arr[i].ToLower(), 1);
                    else
                        words[arr[i].ToLower()]++;
                }
            }
            int sum = arr.Length;
            int frequency = sum / 3;
            if (sum > 5)
                Console.WriteLine("Perfect vocabulary.");
            else
                Console.WriteLine("Poor vocabulary.");
            List <string> preferences = new List <string>();
            foreach (var i in words)
            {
                if (i.Value >= frequency)
                    preferences.Add(i.Key);
                Console.WriteLine($"{i.Key} mentions {i.Value} times");
            }
            Console.WriteLine("Majority of words are:");
            foreach (var i in preferences)
                Console.WriteLine(i);
        }
    }
}
