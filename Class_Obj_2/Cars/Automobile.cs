using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Automobile : Car
    {
        public int Fuel { get; set; }

        public Automobile(int price, int fuel) : base(price)
        {
            this.Price = price;
            this.Fuel = fuel;
        }

        public void Say()
        {
            Console.WriteLine("Price: {0}, Fuel: {1}", this.Price, this.Fuel);
        }
    }
}
