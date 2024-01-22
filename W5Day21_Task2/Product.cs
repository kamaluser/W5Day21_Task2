using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5Day21_Task2
{
    internal class Product
    {
        public string Name {  get; set; }
        public double Price { get; set; }
        public int Count {  get; set; }

        public Product(string name, double price, int count)
        {
            this.Name = name;
            this.Price = price;
            this.Count = count;
        }

    }
}
