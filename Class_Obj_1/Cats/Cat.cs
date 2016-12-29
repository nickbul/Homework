using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats
{
    class Cat: Program
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: {0}, Age: {1}", Name, Age);
        }
    }
}
