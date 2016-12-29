using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Recursions
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.WriteLine("Please enter 2 numbers");
            //int i = int.Parse(Console.ReadLine());
            //int j = int.Parse(Console.ReadLine());
            //MaxNumber(i, j);

            //Console.WriteLine("Please enter three numbers:");
            //int[] arr = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //MaxNumber(arr);

            //2
            //Console.WriteLine("Please enter your name:");
            //PrintName(Console.ReadLine());

            //3
            //Console.WriteLine("Please enter three numbers:");
            //int[,] arr = new int[10,3];
            //Random rand = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 0)
            //    {
            //        for (int j = 0; j < 3; j++)
            //        {
            //            arr[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }
            //    else
            //    {
            //        for (int j = 0; j < 3; j++)
            //        {
            //            arr[i, j] = rand.Next(1, 100);
            //        }
            //    }
            //    Multiplier(arr, i);
            //}

            //4
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Please enter a number");
            //    Chetno(int.Parse(Console.ReadLine()));
            //}

            //5
            //for (int i = 10; i < 1000; i++)
            //{
            //    Simetry(i);
            //}

            //6

            //Console.WriteLine("Please enter a number");
            //int ans = Facturial(int.Parse(Console.ReadLine()));
            //Console.WriteLine(ans);

            //7

            // Ne mojah da go shwana a ne iskam prosto da go kopiram.
            //Console.WriteLine("Please enter a number");
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = i + 1;
            //}

            



        }


        //1
        //private static void MaxNumber(int i , int j)
        //{
        //    if (i>j)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    else
        //    {
        //        Console.WriteLine(j);
        //    }
        //}

        //private static void MaxNumber(int[] i)
        //{
        //    int x = i.Max();
        //    Console.WriteLine(x);
        //}


        //2
        //private static void PrintName(string name)
        //{
        //    Console.WriteLine("Greetings, " + name);
        //}

        //3
        //private static void Multiplier(int[,] arr, int v)
        //{
        //    long x = 1;

        //    for (int i = 0; i < 3; i++)
        //    {
        //        x = x * arr[v, i];
        //    }

        //    Console.WriteLine(x);
        //}

        //4
        //private static void Chetno(int x)
        //{
        //    if (x%2 != 0)
        //    {
        //        Console.WriteLine("Nechetno");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Chetno");
        //    }
        //}

        //5

        //private static void Simetry (int x)
        //{
        //    string a = Convert.ToString(x);


        //    if (a.Length < 3)
        //    {
        //        if (a[0] == a[1])
        //        {
        //            Console.WriteLine(a);
        //        }
        //    }
        //    else
        //    {
        //        if (a[0] == a[2])
        //        {
        //            Console.WriteLine(a);
        //        }
        //    }
        //}

        //6

        //private static int Facturial (int fac)
        //{
        //    int rot = fac;
        //    for (int i = 1; i < fac; i++)
        //    {
        //        rot = rot * i;
        //    }

        //    return rot;
        //}

        //7

        //static void Permute(int x)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.Write(array[i] + 1 + " ");
        //    }
        //    Console.WriteLine();
        //}

    }
}
