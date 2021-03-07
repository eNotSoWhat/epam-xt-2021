using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            Random ran = new Random();
            Console.WriteLine("Array: ");
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = ran.Next(-10, 10);
                    if ((i + j) % 2 == 0)
                        sum += a[i, j];
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Result: {sum}");
        }
    }
}