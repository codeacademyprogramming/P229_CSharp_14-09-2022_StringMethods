using System;
using System.Text;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine(ReversedStr("Salam Qrup Uzvleri"));
        }

        static string ReversedStr(string str)
        {
            string[] arr = str.Split(' ');
            StringBuilder result = new StringBuilder();

            foreach (string item in arr)
            {
                for (int i = item.Length-1; i >= 0; i--)
                {
                    result.Append(item[i]);
                }

                if(item != arr[arr.Length - 1])
                {
                    result.Append('-');
                }
            }

            return result.ToString();
        }
    }
}
