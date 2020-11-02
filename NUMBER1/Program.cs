using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the string: ");
            var sentence = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(sentence))
            {
                Console.WriteLine("String is empty");

            }
            var list = sentence.GroupBy(a => a).ToList();
            foreach(var b in list)
            {
                Console.WriteLine($"Character {b.Key}: {b.Count()} times");
            }
            Console.ReadKey();
        }
    }
}
