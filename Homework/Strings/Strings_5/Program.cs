using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is an apple. This is an orange. I love apples and oranges.";
            Console.WriteLine(sentence);
            Console.WriteLine("Please enter a word");
            string word = Console.ReadLine();
            string[] sentences = sentence.Split('.');

            foreach (string item in sentences)
            {
                if (item.Contains(word))
                {
                    Console.Write(item + ". ");
                }
            }
            Console.WriteLine();
        }
    }
}
