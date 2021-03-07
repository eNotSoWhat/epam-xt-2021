using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            for (int i = 0; i < s1.Length; i++)
            {
                if (s2.IndexOf(s1[i]) != -1)
                    Console.Write(s1[i]);
                Console.Write(s1[i]);
            }
            Console.WriteLine();
        }
    }
}
