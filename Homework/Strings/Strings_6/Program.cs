using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля въведете математически израз със скоби.");
            string sent = Console.ReadLine();
            char[] symbol = sent.ToCharArray();
            int x = 0;
            bool flag = false;

            foreach (char item in symbol)
            {
                if (item == '(')
                {
                    x++;
                }
                else if (item == ')')
                {
                    x--;
                }

                if (x < 0)
                {
                    
                    Print(x, sent, flag);
                    flag = true;
                    break;
                    
                }
            }
            Print(x, sent, flag);
        }

        static void Print(int g, string str, bool f)
        {
            if (f == false)
            {
                if (g == 0)
                {
                    Console.WriteLine(str + " - Вярно");
                }
                else
                {
                    Console.WriteLine(str + " - Грешно");
                }
            }
        }
    }

}
