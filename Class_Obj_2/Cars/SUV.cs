using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class SUV : Car
    {
        public bool High { get; set; }

        public SUV(int price, bool high) : base(price)
        {
            this.Price = price;
            this.High = high;
        }

        public void Say()
        {
            Console.WriteLine("Price: {0}, High: {1}", this.Price, this.High);
        }
    }
}
