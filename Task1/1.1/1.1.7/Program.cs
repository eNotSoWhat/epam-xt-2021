using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Random ran = new Random();
            int tmp = 0;
            Console.WriteLine("Array: ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = ran.Next(-10, 10);
                Console.Write(a[i] + " ");
            }
            int max = a[0];
            int min = a[0];
            Console.WriteLine('\n');
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > max)
                        max = a[j];
                    if (a[j] < min)
                        min = a[j];
                    if (a[j + 1] < a[j])
                    {
                        tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
                }
            Console.WriteLine("Result: ");
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine($"\nMin = {min}, Max = {max}");            
        }
    }
}