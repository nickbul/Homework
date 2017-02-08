using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Izpit_form
{
    public static class Database
    {
        private static string filePath = "Counties.txt";

        public static List<Country> GetAllItems()
        {
            var listOfItems = new List<Country>();

            using (var reader = new StreamReader(filePath))
            {
                var line = reader.ReadLine();
                while (line != null && line != string.Empty)
                {
                    var bookProperties = line.Split('|');

                    listOfItems.Add(new Country()
                    {
                        Countr = bookProperties[0],
                        Capital = bookProperties[1],
                        Population = long.Parse(bookProperties[2]),

                    });

                    line = reader.ReadLine();
                }

                return listOfItems;
            }
        }
    }
}
