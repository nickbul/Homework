using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] names = new string[] { "Lisa", "Misa", "Pisa", "Joe", "Paw", "Jaw", "Kitty", "Jaguar", "Moon", "Puffy" };
            int[] ages = new int[10];

            for (int i = 0; i < 10; i++)
            {
                ages[i] = rand.Next(1, 15);
                var Cat1 = new Cat(names[i], ages[i]);
                Cat1.PrintInfo();
            }



        }
    }
}
