using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля въведете дума");
            string word = Console.ReadLine();
            Console.WriteLine("Моля въведете текст");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            string print;

            foreach (string item in words)
            {
                if (item == word)
                {
                    print = item.ToUpper();
                }
                else
                {
                    print = item;
                }
                Console.Write(print + " ");
            }
            Console.WriteLine();
        }
    }
}
