using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //precision 0.01
            string txt = Console.ReadLine().Trim();
            double sum = 0; int k = 0;
            string[] words = txt.Split(new char[] { '.', ':', '-', ',', '!', '?', ' '});
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length != 0)
                {
                    sum += words[i].Length;
                    k++;
                }
            }
            Console.WriteLine(string.Format("{0:N2}", sum / k));
        }
    }
}