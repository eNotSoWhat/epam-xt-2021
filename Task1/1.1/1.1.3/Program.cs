using System;

namespace task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = (n * 2 - 1) / 2 - 1;
            int r = l;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2 * n; j++)
                {
                    if (j > l && j < r)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                l--; r++;
                Console.WriteLine();
            }
        }
    }
}
