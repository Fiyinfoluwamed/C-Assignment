using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER4
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabets = new List<char>()
            {
                'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
            };
            var vowels = new List<char>()
            {
                'A','E','I','O','U'
            };
            Console.WriteLine("Enter Alphabet: ");
            var alphabet = Convert.ToChar(Console.Read());
            if(char.IsWhiteSpace(alphabet))
            {
                Console.WriteLine("Cannot be empty");
            }
            else
            {
                if(alphabets.Contains(char.ToUpper(alphabet)))
                {
                    if(vowels.Contains(char.ToUpper(alphabet)))
                    {
                        Console.WriteLine($"The alphabet '{alphabet}' is a vowel");
                    }
                    else
                    {
                        Console.WriteLine($"The alphabet '{alphabet}' is a consonant");
                    }

                }
                else
                {
                    Console.WriteLine("Not an alphabet");
                }
            }
            Console.ReadKey();
        }
    }
}
