using System;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            char[] arr = s.ToCharArray();

            Array.Reverse(arr);

            string res = new string(arr);

            if(s == res)
            {
                Console.WriteLine("Palindrom");
            }

            else
            {
                Console.WriteLine("NO");
            }

            Console.ReadKey();
        }
    }
}
