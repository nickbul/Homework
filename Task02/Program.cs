using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            //ushort i = 52130;
            //sbyte j = -115;
            //double a = 4825932.97;
            //decimal t = -10000.20000m;
            //byte b = 224;
            //int c = 970700000;
            //byte d = 112;
            //sbyte e = -44;
            //int f = -1000000;
            //short g = 1990;
            //long h = 123456789123456789;




            //Console.WriteLine("Please enter a number.");
            //double number = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter second number.");
            //double number2 = double.Parse(Console.ReadLine());
            //double sum = number + number2;
            //Console.WriteLine("The sum is: " + sum);

            //bool condition = false;
            //Console.WriteLine("Please enter 'Hello World'");
            //string hw = Convert.ToString(Console.ReadLine());
            //if (hw == "Hello World")
            //{
            //    condition = true;
            //}
            //Console.WriteLine("The strings are identical: " + condition.ToString());

            //Console.WriteLine("Please enter the first rectangle side:");
            //short number = short.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the second rectangle side:");
            //short number2 = short.Parse(Console.ReadLine());
            //int sqr = number * number2;
            //Console.WriteLine("The rectange area is: " + sqr);

            //Console.WriteLine("Please enter the first number:");
            //short number = short.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the second number:");
            //short number2 = short.Parse(Console.ReadLine());
            //int sqr = number % number2;
            //Console.WriteLine("The division left is: " + sqr);

            //Console.WriteLine("Please enter text");
            //string text1 = Console.ReadLine();
            //Console.WriteLine("Please enter text again");
            //string text2 = Console.ReadLine();
            //Console.WriteLine(text1 + "|" + text2);

            //Console.WriteLine("Please enter real number:");
            //double number = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter real number:");
            //int number2 = int.Parse(Console.ReadLine());
            //double div = number / number2;
            //Console.WriteLine("The division is: " + div);

            //Console.WriteLine("Please enter text");
            //string text1 = Console.ReadLine();
            //Console.WriteLine("the second simbol is: " + text1[1]);

            int spaces = 10;
            int symbols = 1;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                if (spaces == 10)
                {
                    Console.Write("o");
                }
                else
                {
                    for (int j = 1; j < symbols * 2; j++)
                    {
                        Console.Write("o");
                    }
                }
                Console.WriteLine();
                symbols++;
                spaces--;
             }
            Console.WriteLine("          |");
            Console.WriteLine("          |");
            Console.WriteLine("          =");
        }
    }
}
