using System;

namespace newString
{
    class StringArray
    {
        private int len;
        private char[] arr;
        public StringArray saInit()
        {
            StringArray x = new StringArray();
            x.len = 0;
            x.arr = new char[0];
            return x;
        }
        public StringArray saRead()
        {
            StringArray x = new StringArray();
            string s = Console.ReadLine();
            x.len = s.Length;
            char[] arr = new char[x.len];
            for (int i = 0; i < x.len; i++)
            {
                arr[i] = s[i];
            }
            x.arr = arr;
            return x;
        }
        public void saPrint()
        {
            Console.WriteLine($"Size: {len}");
            Console.Write("StringArray: ");
            for (int i = 0; i < len; i++)
                Console.Write(arr[i]);
            Console.WriteLine();
        }
        public int saFind(char c)
        {
            int f = -1;
            for (int i = 0; i < len; i++)
            {
                if (arr[i] == c)
                    f = i;
            }
            return f;
        }
        public int saCompare(StringArray x)
        {
            if (len < x.len)
                return -1;
            else if (x.len == len)
            {
                for (int i = 0; i < len; i++)
                    if (arr[i] < x.arr[i])
                        return -1;
                    else if (arr[i] > x.arr[i])
                        return 1;
                return 0;
            }
            return 1;
        }
        public StringArray saConcatinate(StringArray x)
        {
            StringArray ans = new StringArray();
            ans.len = len + x.len;
            ans.arr = new char[ans.len];
            for (int i = 0; i < len; i++)
                ans.arr[i] = arr[i];
            for (int i = len; i < ans.len; i++)
                ans.arr[i] = x.arr[i - len];
            return ans;
        }
        public void saReverse()
        {
            char[] ans = new char[len];
            for (int i = 0; i < len; i++)
                ans[i] = arr[len - 1 - i];
            arr = ans;
        }

        public static implicit operator string (StringArray x)
        {
            string ans = "";
            for (int i = 0; i < x.len; i++)
            {
                ans += x.arr[i];
            }
            return ans;
        }

        public static implicit operator StringArray (string x)
        {
            StringArray ans = new StringArray();
            for (int i = 0; i < x.Length; i++)
            {
                ans.arr[i] = x[i];
            }
            ans.len = x.Length;
            return ans;
        }
        static void Main()
        {
            
        }
    }
}
