using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("filename: "+args[0]);
            
            Queue<string> qs = new Queue<string>(); 
            string inp;

            do
            {
                inp= Console.ReadLine();

                if (inp=="")
                    break;

                qs.Enqueue(inp);

            } while (true);



            WriteAllLines(args[0], qs);






            void WriteAllLines(string path, IEnumerable<string> contents)
            {
                StreamWriter sr = new StreamWriter(path);

                foreach (string s in contents)
                {
                    sr.WriteLine(s);
                }

                sr.Close();
            }
            
        }
    }
}

