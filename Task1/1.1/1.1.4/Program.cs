using System;

namespace task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int k = 0; k < n; k++)
            {
                int l = n - 1;
                int r = l;
                for (int i = 0; i < k + 1; i++)
                {
                    for (int j = 0; j < 2 * n; j++)
                    {
                        if (j >= l && j <= r)
                            Console.Write('*');
                        else
                            Console.Write(' ');
                    }
                    Console.WriteLine();
                    l--; r++;
                }
            }
        }
    }
}