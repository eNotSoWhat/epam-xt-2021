using System;
using System.Collections.Generic;

namespace SuperArray
{
    public static class NewMethod
    {
        delegate int Operation (int x, int y);

        public static int Add (int x, int y)
        {
            return x + y;
        }
        public static int Mul (int x, int y)
        {
            return x * y;
        }
        public static int Div (int x, int y)
        {
            return x / y;
        }
        public static int Sub (int x, int y)
        {
            return x - y;
        }

        public static int Sum (int[] array)
        {
            int ans = 0;
            foreach (int x in array)
                ans += x;
            return ans;
        }

        public static int Agv (int[] array)
        {
            int ans = 0;
            foreach (int x in array)
                ans += x;
            return ans / array.Length;
        }

        public static int Pref(int[] array)
        {
            Dictionary <int, int> hlp = new Dictionary <int, int> (array.Length);

            for (int i = 0; i < array.Length; i++)
            {
                if (!hlp.ContainsKey(array[i]))
                {
                    hlp.Add(array[i], 1);
                }
                else
                {
                    hlp[array[i]]++;
                }
            }

            int max = 0;
            int ans = 0;

            foreach (var x in hlp)
            {
                if (x.Value > max)
                {
                    max = x.Value;
                    ans = x.Key;
                }
            }
            return ans;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter two numbers.");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose an operation: Add, Sub, Mul or Div.");
                string choice = Console.ReadLine();
                Operation task = Add;
                switch (choice)
                {
                    case "Add":
                        Console.WriteLine(task(x, y));
                        break;
                    case "Sub":
                        task = Sub;
                        Console.WriteLine(task(x, y));
                        break;
                    case "Mul":
                         task = Mul;
                        Console.WriteLine(task(x, y));
                        break;
                    case "Div":
                        task = Div;
                        Console.WriteLine(task(x, y));
                        break;
                }
            }
        }
    }
}
