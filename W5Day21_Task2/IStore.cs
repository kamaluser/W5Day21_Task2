using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5Day21_Task2
{
    internal interface IStore
    {
        public Product[] Products { get; }
        public int ProductLimit { get; set; }
        public double TotalIncome { get; set; }

        public void AddProduct(Product product);
        public void SellProduct(string Name);

    }
}
