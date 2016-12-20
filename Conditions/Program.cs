using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st

            //int x;
            //double d;
            //string s;

            //string decision;
            //Console.WriteLine("Please enter 1 for Int");
            //Console.WriteLine("2 for Double");
            //Console.WriteLine( "and 3 for String");
            //int i = int.Parse(Console.ReadLine());

            //if (i == 1)
            //{
            //    decision = "Int";
            //}
            //else if (i == 2)
            //{
            //    decision = "Double";
            //}
            //else
            //{
            //    decision = "String";
            //}

            //Console.WriteLine("Now enter your " + decision);

            //if (i == 1)
            //{
            //    x = int.Parse(Console.ReadLine());
            //    x++;
            //    Console.WriteLine("Int: " + x);
            //}
            //else if (i == 2)
            //{
            //    d = double.Parse(Console.ReadLine());
            //    d++;
            //    Console.WriteLine("Double: " + d);
            //}
            //else
            //{
            //    s = Console.ReadLine();
            //    s = s + "*";
            //    Console.WriteLine("String: " + s);
            //}


            // 2nd

            //Console.WriteLine("Please enter your points 1:9");
            //int i = int.Parse(Console.ReadLine());

            //if (i > 0 && i <=3)
            //{
            //    i = i + 5;
            //    Console.WriteLine(i);
            //}
            //else if (i > 3 && i < 7)
            //{
            //    i = i * 12;
            //    Console.WriteLine(i);
            //}
            //else if (i >6 && i <10)
            //{
            //    i = (i * 50) / 3;
            //    Console.WriteLine(i);
            //}
            //else
            //{
            //    Console.WriteLine("Nor in range - 1:9");
            //}

            // 3rd


            Console.WriteLine("Моля въведете карта");
            string s = Console.ReadLine();


            switch (s)
            {
                case "2":

                case "3":

                case "4":

                case "5":

                case "6":

                case "7":

                case "8":

                case "9":

                case "10":

                case "J":

                case "Q":

                case "K":

                case "A":
                    Console.WriteLine("Валидна карта");
                    break;

                default:
                    Console.WriteLine("Невалидна карта");
                    break;

            }
        }
    }
}
