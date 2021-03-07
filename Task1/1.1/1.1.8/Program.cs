using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] a = new int[10, 10, 2];
            Random ran = new Random();
            int tmp = 0;
            Console.WriteLine("Array: ");
            for (int k = 0; k < 2; k++)
            {

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        a[i, j, k] = ran.Next(-10, 10);
                        Console.Write(a[i, j, k] + " ");
                    }
                    Console.WriteLine(); 
                }
                Console.WriteLine();
            }

            Console.WriteLine("Result: ");
            for (int k = 0; k < 2; k++)
            {

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (a[i, j, k] > 0)
                            a[i, j, k] = 0;
                        Console.Write(a[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}