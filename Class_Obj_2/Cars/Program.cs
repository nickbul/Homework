using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int[] Price = new int[10];
            int[] Fuel = new int[5];
            bool[] High = new bool[10];

            for (int i = 0; i < 10; i++)
            {

                if (i < 5)
                {
                    Price[i] = ran.Next(1500, 25000);
                    Fuel[i] = ran.Next(4, 15);
                    Automobile auto = new Automobile(Price[i], Fuel[i]);
                    auto.Say();
                }
                else
                {
                    Price[i] = ran.Next(9000, 75000);
                    int x = i % 2;
                    if (x==0)
                    {
                        High[i] = true;
                    }
                    SUV suv = new SUV(Price[i], High[i]);
                    suv.Say();
                }
            }

        }


    }
    
}
