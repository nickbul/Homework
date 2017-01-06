using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srings_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Моля въведете текст");
            string sentence = Console.ReadLine();
            Console.WriteLine("Моля въведете дума");
            string word = Console.ReadLine();
            string[] words = sentence.Split(' ');
            int x = 0;

            foreach (string item in words)
            {
                if (item == word)
                {
                    x++;
                }
            }
            Console.WriteLine(x);
        }
    }
}
