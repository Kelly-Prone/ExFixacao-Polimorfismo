using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nProduct #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char productType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (productType == 'c')
                {
                    products.Add(new Product(name, price));
                }
                else if (productType == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime dateTime = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, dateTime));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsfee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }


        }
    }
}
