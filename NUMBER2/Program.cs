using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER2
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new string[9]
            {
                " ROME", " NEW DELHI"," PARIS"," LONDON"," ZURICH", " CARLIFORNIA"," NAIROBI"," ABU DHABI", " AMSTERDAM"
            };
            var arrangedList = arr.OrderBy(a => a.Length).ThenBy(b => b.First()).ToList();
            foreach(var c in arrangedList)
            {
                Console.WriteLine($"{c}");
            }
            Console.ReadKey();
        }
        

    }
}
