using System;

namespace task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > 0 && b > 0)
                Console.WriteLine(a * b);
            else
                Console.WriteLine("Wrong input");
        }
    }
}
