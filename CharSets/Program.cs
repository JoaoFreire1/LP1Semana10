using System;

namespace CharSets
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");
            string s;
            using StreamReader sr = new StreamReader("file1.txt");
            while ((sm= sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}
