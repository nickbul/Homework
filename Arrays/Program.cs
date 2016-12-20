using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st

            //int[] FirstArray = new int[] { 1, 2, 3, 4, 5, 6 };
            //int[] SecondArray = new int[6];

            //for (int i = 0; i < 6; i++)
            //{
            //    SecondArray[i] = FirstArray[i];
            //    Console.WriteLine("Second Array: " + SecondArray[i]);
            //}

            //2nd

            //int[] FirstArray = new int[] { 1, 2, 3, 4, 5, 6 };
            //int[] SecondArray = new int[6];
            //int j = 5;

            //for (int i = 0; i < 6; i++)
            //{
            //    SecondArray[j] = FirstArray[i];
            //    Console.WriteLine("Original Array: " + FirstArray[i]);
            //    j--;
            //}

            //for (int i = 0; i < 6; i++)
            //{
            //    FirstArray[i] = SecondArray[i];
            //    Console.WriteLine("Reversed Array: " + FirstArray[i]);
            //}

            //3rd
            //Напишете програма, която проверява дали един масив е симетричен
            //Тук ще помоля за уточнение.

            //4th

            //int[] myArray = new int[] { 1, 2, 3, 4, 5, 6,7,8,9,10 };
            //int x = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    if (myArray[i]%2 == 0)
            //    {
            //        x = x + myArray[i];
            //    }
            //}
            //Console.WriteLine("Total:" + x);

            //5th

            //Console.WriteLine("Please enter a number:");
            //int x = int.Parse(Console.ReadLine());
            //int[] myArray = new int[x];

            //for (int i = 0; i < x; i++)
            //{
            //    if (i==0)
            //    {
            //       myArray[i]=0; 
            //    }
            //    else if (i >=1 && i<=2)
            //    {
            //        myArray[i]=1; 
            //    }
            //    else
            //    {
            //        myArray[i] = myArray[i-2] + myArray[i-1];
            //    }
            //}
            
            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            //Console.WriteLine(myArray[x-2] + myArray[x-1]);

            //6th

            //int[] newArray = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    newArray[i] = i*10;
            //}

            //7th

            //int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Console.WriteLine("Please enter a number from 1 to 10: ");
            //int x = int.Parse(Console.ReadLine());
            //int IndEx = 0;

            //IndEx = Array.IndexOf(myArray, x);
            //Console.WriteLine("Index: " + IndEx);

            //8th 

            //int[] FirstArray = new int[5];
            //int[] SecondArray = new int[5];
            //Console.WriteLine("Please enter 5 numbers:");
            //for (int i = 0; i < 5; i++)
            //{
            //    FirstArray[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Please enter another 5 numbers:");
            //for (int i = 0; i < 5; i++)
            //{
            //    SecondArray[i] = int.Parse(Console.ReadLine());
            //}

            //var EquaL = FirstArray.Except(SecondArray);

            //if (EquaL.Count() == 0)
            //{
            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //}

            //9th

            //int[] myArray = new int[] { 4, 1, 1, 4, 2, 3, 4, 8, 1, 2, 4, 9, 3,10,6,7 };
            //Console.WriteLine("Please enter a number from 1 to 10");
            //int x = int.Parse(Console.ReadLine());
            //int y = 0;

            //for (int i = 0; i < 16; i++)
            //{
            //    if (x==myArray[i])
            //    {
            //        y++;
            //    }
            //}
            //Console.WriteLine(y);

            //10th

            //Console.WriteLine("Please enter the first dimention of the array");
            //byte x = byte.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the second dimention of the array");
            //byte y = byte.Parse(Console.ReadLine());
            //int count =1;

            //int[,] Darray = new int[x, y];

            //for (int i = 0; i < y; i++)
            //{
            //    for (int j = 0; j < x; j++)
            //    {
            //        Darray[i, j] = count;
            //        count++;
            //    }
            //}

            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write(Darray[j, i] + " ");
            //    }
            //    Console.WriteLine();
            //}
            
            //11th

            Console.WriteLine("Please enter 4 :)");
            byte x = byte.Parse(Console.ReadLine());
            byte y = x;
            int count = 1;
            int square = x * y;


            int[,] Darray = new int[x, y];

            for (int j = 0; j < y; j++)
            {
                Darray[j, 0] = count;
                count++;
            }

            for (int i = 1; i < x; i++)
            {
                Darray[x - 1, i] = count;
                count++;
            }

            for (int i = x-2; i >= 0; i--)
            {
                Darray[i, y-1] = count;
                count++;
            }

            for (int i = x-2; i >= 1; i--)
            {
                Darray[0, i] = count;
                count++;
            }

            for (int i = 1; i < x-1; i++)
            {
                Darray[i, 1] = count;
                count++;
            }

            for (int i = x-2 ; i >= 1; i--)
            {
                Darray[i, x-2] = count;
                count++;
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(Darray[j, i] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
