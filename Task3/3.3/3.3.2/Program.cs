using System;
using System.Linq;

namespace SuperString
{
    public static class StringCheck
    {
        public static string Check (this string str)
        {
            char[] chars = str.ToCharArray();

            bool rusString = chars.All(c => (c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я'));
            bool engString = chars.All(c => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));
            bool numString = chars.All(c => (c >= '0' && c <= '9'));

            if (rusString)
            {
                return "Russian";
            }
            else if (engString)
            {
                return "English";
            }
            else if (numString)
            {
                return "Numbers";
            }
            return "Mixed";
        }
        class Program
        {
            static void Main()
            {
                string s = Console.ReadLine();
                Console.WriteLine(s.Check());
            }
        }
    }
}
