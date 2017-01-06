using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Strings_8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Не работи както трябва и не мога да разбера защо. Обръща четно и нечетно и пропуска първия ред.
                using (StreamReader reader = new StreamReader("../../obj/Text.txt"))
                {
                    string line = reader.ReadLine();
                    int numb = 2;

                    while (line != null && line != string.Empty)
                    {
                        numb++;
                        line = reader.ReadLine();     

                        
                        if ((numb % 2) != 0)
                        {
                            using (StreamWriter write = new StreamWriter("odd.txt", true))
                            {
                                write.WriteLine(line);
                            }
                        }
                        else
                        {
                            using (StreamWriter write2 = new StreamWriter("even.txt", true))
                            {
                                write2.WriteLine(line);
                            }
                        }
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
