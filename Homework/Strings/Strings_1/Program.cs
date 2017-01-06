using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Strings_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> written = new List<string>();
                int numb = 0;

                using (StreamReader reader = new StreamReader("../../obj/countries.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null && line != string.Empty)
                    {
                        Console.WriteLine("Please enter the capital of this country: " + line);
                        written.Add(Console.ReadLine());
                        numb++;
                        line = reader.ReadLine();
                    }

                }
                using (StreamWriter write = new StreamWriter("Capitals.txt", true))
                {
                    for (int i = 0; i < numb; i++)
                    {
                        write.WriteLine(written[i]);
                    }
                }
            }
            catch (FileNotFoundException)
            {

                Console.WriteLine("File not foumd");
            }

        }
    }
}
