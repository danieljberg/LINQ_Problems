using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            foreach(var word in words)
            {
                if(word.Contains("th"))
                {
                    Console.WriteLine(word);
                }
            }
            Console.ReadLine();
        }
    }
}
