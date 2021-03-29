using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //precision 0.01
            string txt = Console.ReadLine().Trim();
            string tmp; 
            int k = 0;
            string[] words = txt.Split(new char[] { '.', ':', '-', ',', '!', '?', ' '});
            for (int i = 0; i < words.Length; i++)
            {
                tmp = words[i];
                if (tmp[0] >= 'a' && tmp[0] <= 'z')
                {
                    k++;
                }
            }
            Console.WriteLine(k);
        }
    }
}
