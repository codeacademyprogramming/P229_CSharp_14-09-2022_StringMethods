using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Helplo World";

            //string[] arr = { "Hello", "Wordl", "P229" };

            //string joinedStr = String.Join(" Code ", arr);

            //Console.WriteLine(joinedStr);

            //Console.WriteLine(word.Contains('z'));
            //Console.WriteLine(word.Contains("Hdasdadasd"));
            //bool check = word.EndsWith("World");
            //Console.WriteLine(check);

            //Console.WriteLine(word.IndexOf('W'));
            //Console.WriteLine(word.IndexOf('l',word.IndexOf('l',word.IndexOf('l')+1)+1));
            //Console.WriteLine(word.LastIndexOf('l', word.LastIndexOf('l')-1));

            char[] letters = { 'e', 'a', 'o' };

            //Console.WriteLine(word.IndexOfAny(letters));
            //Console.WriteLine(word.LastIndexOfAny(letters));
            //Console.WriteLine(word.PadLeft(15));
            //Console.WriteLine(word.PadLeft(15).Length);

            //Console.WriteLine(word.Remove(3,3));
            //Console.WriteLine(word.Replace("lWorld", "P229"));
            //Console.WriteLine(word.StartsWith("Hello"));
            //string newSubStr = word.Substring(0, 5);
            //Console.WriteLine(newSubStr);

            //Console.WriteLine(word.ToLower());
            //Console.WriteLine(word.ToUpper());
            //Console.WriteLine(word.ToLowerInvariant());
            //Console.WriteLine(word.ToUpperInvariant());
            //Console.WriteLine(word.Length);
            //Console.WriteLine(word.Trim());
            //Console.WriteLine(word.Trim().Length);
            //Console.WriteLine(word.TrimStart().Length);
            //Console.WriteLine(word.TrimStart());

            //Console.WriteLine(word.TrimEnd().Length);
            //Console.WriteLine(word.TrimEnd());

            //string[] arr = word.Split("lo");
            //Console.WriteLine(arr.Length);
            //foreach (string item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //string userName = "hamidvm";
            //string email = "hamidvm@code.edu.az";

            //Console.WriteLine(userName == email);
            //Console.WriteLine(email.Contains(userName));

            string str = Console.ReadLine();

            //int.TryParse(str,out int num);
            int num;

            while (!int.TryParse(str,out num))
            {
                Console.WriteLine("Duzgun Daxil et");
                str = Console.ReadLine();
            }

            char.TryParse(str, out char letter);

            Console.WriteLine(num);
        }
    }
}
