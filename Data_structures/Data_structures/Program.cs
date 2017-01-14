using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1st
            //ArrayList list = new ArrayList();
            //int x = 0;
            //int i = 0;

            //list.Add(Console.ReadLine());

            //while (list[i].ToString() != string.Empty)
            //{
            //    x = x + Convert.ToInt32(list[i]);
            //    i++;
            //    list.Add(Console.ReadLine());
            //}


            //Console.WriteLine("Sum is: " + x);
            //Console.WriteLine("Mean is: " + x/i);

            ////2nd

            //List<int> numbs = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            //List<int> torem = new List<int> { };
            //int x = 0;

            //for (int i = 0; i < numbs.Count; i++)
            //{

            //    for (int j = 1; j < numbs.Count; j++)
            //    {
            //        if (numbs[i] == numbs[j])
            //        {
            //            x++;
            //        }
            //    }

            //    if (x%2 == 0 && x != 0)
            //    {
            //        torem.Add(numbs[i]);
            //    }

            //    x = 0;
            //}

            //foreach (var item in torem)
            //{
            //    Console.Write(item + ", ");
            //}

            //Console.WriteLine();

            ////3rd

            //List<int> broi = new List<int> { };
            //Random rand = new Random();

            //for (int i = 0; i < 1000; i++)
            //{
            //    broi.Add(rand.Next(1, 11));
            //}

            //int x = 0;

            //for (int i = 1; i < 11; i++)
            //{
            //    for (int j = 0; j < broi.Count; j++)
            //    {
            //        if (i == broi[j])
            //        {
            //            x++;
            //        }
            //    }

            //    Console.WriteLine(i + ": " + x);
            //    x = 0;
            //}

            ////4th
            //List<int> major = new List<int> { };
            //Random rand = new Random();
            //int x = 3;

            //for (int i = 0; i < 100; i++)
            //{
            //    major.Add(rand.Next(1, x));
            //}

            //int[] sums = new int[x];

            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < major.Count; j++)
            //    {
            //        if (i+1 == major[j])
            //        {
            //            sums[i]++;
            //        }
            //    }
            //}

            //int val = sums[0];
            //int ind = 1;
            //for (int i = 1; i < sums.Length; i++)
            //{
            //    if (sums[i] > val )
            //    {
            //        val = sums[i];
            //        ind = i+1;
            //    }
            //}

            //if (val >= major.Count / 2 +1)
            //{
            //    Console.WriteLine("The majorant is: " + ind + " : " + val);
            //}
            //else
            //{
            //    Console.WriteLine("The majorant does not exist!");
            //}


            ////5th

            //Console.WriteLine("Please enter 20 words");

            //List<string> words = new List<string> { "qw", "qw","er","er","ff","ff","ds","Int","swe","sefg","Dog","Nice","Too","Better","How","Int" };
            ////{ "qw", "qw","er","er","ff","ff","ds","Int","swe","sefg","Dog","Dog","Dog","Nice","Too","Better","How","How","Int","Int" };
            //int count = 1; 

            ////for (int i = 0; i < 20; i++)
            ////{
            ////    words.Add(Console.ReadLine());
            ////}

            //Dictionary<string, int> dict = new Dictionary<string, int>();

            //for (int i = 0; i < words.Count; i++)
            //{
            //    string wrd = words[i];
            //    int g = i + 1;
            //    if (g < words.Count)
            //    {
            //        for ( int j = g ; j < words.Count; j++)
            //        {
            //            if (wrd == words[j])
            //            {
            //                count++;
            //                words.Remove(words[j]);
            //            }
            //        }
            //        dict.Add(wrd, count);
            //        count = 1;
            //    }

            //}

            //foreach (var item in dict)
            //{
            //    Console.WriteLine(item);
            //}

            ////6th

            //Console.WriteLine("Please enter text.");
            //string sent = Console.ReadLine();
            //string[] separators = {",", ", ", " ", "."};
            //List<string> words = new List<string>(sent.Split(separators,StringSplitOptions.RemoveEmptyEntries));
            //string wrd;

            //bool flag = false;
            //for (int i = 0; i < words.Count; i++)
            //{
            //    wrd = words[i];
            //    int g = i + 1;
            //    if (g < words.Count)
            //    {
            //        for (int j = g; j < words.Count; j++)
            //        {
            //            if (wrd == words[j])
            //            {
            //                words.RemoveAt(j);
            //                flag = true;
            //            }
            //        }

            //        if (flag == true)
            //        {
            //            words.RemoveAt(i);
            //            i--;
            //            flag = false;
            //        }
            //    }

            //}
            //Console.WriteLine("**********************************");
            //for (int i = 0; i < words.Count; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}


            //7th

            Console.WriteLine("Please enter five cards (2:10 and A,J, Q,K):");
            Dictionary<int, int> dcards = new Dictionary<int, int>();
            List<int> cards = new List<int>();
            string card;

            for (int i = 0; i < 5; i++)
            {
                card = Console.ReadLine();
                switch (card)
                {
                    case "2":
                        cards.Add(2);
                        break;
                    case "3":
                        cards.Add(3);
                        break;
                    case "4":
                        cards.Add(4);
                        break;
                    case "5":
                        cards.Add(5);
                        break;
                    case "6":
                        cards.Add(6);
                        break;
                    case "7":
                        cards.Add(7);
                        break;
                    case "8":
                        cards.Add(8);
                        break;
                    case "9":
                        cards.Add(9);
                        break;
                    case "10":
                        cards.Add(10);
                        break;
                    case "A":
                        cards.Add(14);
                        break;
                    case "J":
                        cards.Add(11);
                        break;
                    case "K":
                        cards.Add(13);
                        break;
                    case "Q":
                        cards.Add(12);
                        break;
                        
                    default:
                        Console.WriteLine("Please enter: 2:10, A, J, Q or K");
                        i--;
                        break;
                }

            }

            int count;
            int vset = 0;
            bool set = false;
            cards.Sort();
            for (int i = 0; i < cards.Count; i++)
            {
                count = 0;
                if (i < cards.Count -1)
                {
                    for (int j = i + 1; j < cards.Count; j++)
                    {
                        if (cards[i]==cards[j])
                        {
                            count++;
                        }
                        if (cards[i] == cards[j]-1 )
                        {
                            vset++;
                        }
                    }
                }

                dcards.Add(i, count);
            }

            if (vset >= 4)
            {
                set = true;
            }

            int x = dcards[0];
            for (int i = 1; i < dcards.Count; i++)
            {
                if (x < dcards[i])
                {
                    x = dcards[i];
                }
            }

            if (x > 1 && x < 3)
            {
                Console.WriteLine("Чифт");
            }
            else if (x == 3)
            {
                Console.WriteLine("Каре");
            }
            else if (set == true)
            {
                Console.WriteLine("Сет");
            }
            else
            {
                Console.WriteLine("Нищо");
            }
        }
    }
}
