using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word:");
            string word = Console.ReadLine();
            for (int i = word.Length; i >= 1; i--)
            {
                Console.Write(word[i-1]);

            }
            Console.WriteLine();

        }
    }
}
