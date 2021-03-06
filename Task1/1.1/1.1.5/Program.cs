using System;

namespace task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int ans = 0;
            for (int i = 1; i < 1001; i++)
                if (i % 3 == 0 || i % 5 == 0)
                {
                    ans += i;
                }
            Console.WriteLine(ans);
        }
    }
}