using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace W5Day21_Task2
{
    internal class Market:IStore
    {
        private Product[] products = new Product[0];
        public Product[] Products => products;
        public int ProductLimit { get; set; }

        public double TotalIncome { get; set; }

        private int productCount;

        public Market(int productLimit)
        {
            ProductLimit = productLimit;
            products = new Product[ProductLimit];
            productCount = 0;
        }

        public void AddProduct(Product product)
        {
            bool productExists = false;
            for (int i = 0; i < productCount; i++)
            {
                if (products[i] != null && products[i].Name == product.Name)
                {
                    productExists = true;
                    break;
                }
            }

            if (productCount < ProductLimit && !productExists)
            {
                products[productCount] = product;
                productCount++;
                Console.WriteLine("Product added successfully.");
            }
            else
            {
                Console.WriteLine("Product limit reached or product with the same name already exists.");
            }

        }

        public void SellProduct(string name)
        {
            bool productFound = false;
            for (int i = 0; i < productCount; i++)
            {
                if (products[i].Name == name && products[i].Count > 0)
                {
                    products[i].Count--;
                    TotalIncome += products[i].Price;
                    productFound = true;
                    break;
                }
            }
            if (productFound == true)
            {
                Console.WriteLine("Product sold successfully.");
            }
            else
            {
                Console.WriteLine("Product not found or out of stock.");
            }
            
        }
        public void ShowProducts()
        {
            for(int i = 0;i < products.Length;i++)
            {
                Console.WriteLine($"{i}.\nName: {Products[i].Name}\nPrice: {Products[i].Price}\nCount: {Products[i].Count}");
            }
        }
    }
}
