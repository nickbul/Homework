using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car 
    {
        public int Price { get; set; }

        public Car(int price):base()
        {
            this.Price = price;
        }
    }
}
