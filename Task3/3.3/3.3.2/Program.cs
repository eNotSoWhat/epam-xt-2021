using System;
using System.Linq;

namespace SuperString
{
    public static class StringCheck
    {
        public static string Check (this string str)
        {
            char[] chars = str.ToCharArray();

            bool rus = chars.All(c => (c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я'));
            bool eng = chars.All(c => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));
            bool num = chars.All(c => (c >= '0' && c <= '9'));

            if (rus)
            {
                return "Russian";
            }
            else if (eng)
            {
                return "English";
            }
            else if (num)
            {
                return "Numbers";
            }
            return "Mixed";
        }
        class Program
        {
            static void Main()
            {
                string str = Console.ReadLine();
                Console.WriteLine(str.Check());
            }
        }
    }
}
