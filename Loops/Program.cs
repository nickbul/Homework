using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //1st 
            //Console.WriteLine("Please enter number");
            //int c = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter a second number");
            //int j = int.Parse(Console.ReadLine());
            //int x;

            //if (c>j)
            //{
            //    x=j;
            //}
            //else
            //{
            //    x=c;
            //}

            //for (int i =x; i > 0; i--)
            //{
            //    if (c%i == 0 && j%i==0)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}


            //2nd

            //Console.WriteLine("Please enter a number 1");
            //int j = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= j; i++)
            //{
            //    if (i%3!=0 && i%7 !=0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //3rd

            int c = 1;
            int[] j = new int[5];


            for (int i = 0; i <=4; i++)
            {
                Console.WriteLine("Please enter number " + c + " of 5");
                j[i] = int.Parse(Console.ReadLine());
                c++;
            }


            Console.WriteLine("Maximum value: " + j.Max());
            Console.WriteLine("Minimum value: " + j.Min());
        }
    }
}
