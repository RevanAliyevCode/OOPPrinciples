using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Products
{
    public class Orders
    {
        public Product[] Products { get; private set; } = [];

        public void AddProduct(Product product)
        {
            var tempArray = new Product[Products.Length + 1];
            Array.Copy(Products, tempArray, Products.Length);

            tempArray[Products.Length] = product;

            Products = tempArray;
        }

        public void RemoveProduct(Product product)
        {
            var tempArray = new Product[Products.Length - 1];
            int index = 0;

            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Id != product.Id)
                {
                    if (index + 1 < Products.Length)
                    {
                        tempArray[index] = Products[i];
                        index++;
                    }
                    else
                    {
                        Console.WriteLine("Bu mehsul sifarisde yoxdu");
                        return;
                    }
                }
            }

            Products = tempArray;
        }

        public decimal GetTotalAmount()
        {
            decimal total = 0;

            foreach (var price in Products)
                total += price.Price;

            return total;
        }

        public void GetProductsDetails()
        {
            foreach (var product in Products) product.GetDetails();
        }
    }
}
