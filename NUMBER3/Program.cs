using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the word: ");
            var word = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(word))
            {
                Console.WriteLine("Empty input");
            }
            else
            {
                if (word.Trim().Length == 1)
                {
                    Console.WriteLine("Rewrite Word: " + word.Trim());

                }
                else
                {
                    var firstCharacter = word.First();
                    var lastCharacter = word.Last();
                    var middleWord = word.Substring(1, (word.Length - 2));
                    var newWord = $"{lastCharacter}{middleWord}{firstCharacter}";
                    Console.WriteLine("New word: " + newWord);
                }
            }
            Console.ReadKey();
        }
    }
}
