using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Strings_7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                List<string> written = new List<string>();
                string dirty;
                string clean;
                using (StreamReader reader = new StreamReader("../../obj/Text.txt"))
                {
                    dirty = reader.ReadToEnd();
                    //Regex rgx = new Regex("^[a-zA-Z0-9 _]+$");
                    //clean = rgx.Replace(dirty, "");
                    //clean = Regex.Replace(dirty, @"^[a-zA-Z0-9 _]+$"," ");
                    clean = dirty.Replace(".", "");
                    clean = clean.Replace(",", "");
                    clean = clean.Replace("!", "");
                    clean = clean.Replace("?", "");

                }
                using (StreamWriter write = new StreamWriter("Clean.txt", true))
                {
                        write.Write(clean);
                }
            }
            catch (FileNotFoundException)
            {

                Console.WriteLine("File not foumd");
            }
}
    }
}
