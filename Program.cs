using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"Text.txt", Encoding.UTF8);
            Console.WriteLine(sr.ReadToEnd());
            Console.ReadKey();
        }
    }
}