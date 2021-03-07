using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[8];
            Random ran = new Random();
            int sum = 0;
            Console.WriteLine("Array: ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = ran.Next(-100, 100);
                if (a[i] >= 0)
                    sum += a[i];
                Console.Write(a[i] + " ");
            }
            Console.WriteLine('\n');
            Console.WriteLine($"Sum = {sum}");
        }
    }
}