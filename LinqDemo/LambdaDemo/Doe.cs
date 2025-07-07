using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    class Doe
    {
        static List<Product> products = new()
        {
            new Product { Description = "Wireless Mouse", Price = 24.99m },
            new Product { Description = "Mechanical Keyboard", Price = 79.99m },
            new Product { Description = "27-inch Monitor", Price = 189.99m },
            new Product { Description = "USB-C Hub", Price = 29.99m },
            new Product { Description = "Laptop Stand", Price = 39.99m },
            new Product { Description = "Noise Cancelling Headphones", Price = 129.99m },
            new Product { Description = "External SSD 1TB", Price = 99.99m },
            new Product { Description = "Webcam 1080p", Price = 49.99m },
            new Product { Description = "Bluetooth Speaker", Price = 59.99m },
            new Product { Description = "Portable Charger 20000mAh", Price = 45.99m },
            new Product { Description = "Smartphone Tripod", Price = 19.99m },
            new Product { Description = "Ergonomic Chair", Price = 249.99m },
            new Product { Description = "Graphic Tablet", Price = 89.99m },
            new Product { Description = "Smart Light Bulb", Price = 14.99m },
            new Product { Description = "Streaming Microphone", Price = 74.99m },
            new Product { Description = "4K Action Camera", Price = 159.99m },
            new Product { Description = "Smart Watch", Price = 199.99m },
            new Product { Description = "Fitness Tracker", Price = 49.99m },
            new Product { Description = "VR Headset", Price = 299.99m },
            new Product { Description = "Gaming Controller", Price = 59.99m }
        };


        public static void Hoi()
        {
            PrintExpensiveProducts();
            Console.WriteLine("==============");
            PrintProductsBeginningWithLetter("S");
            Console.WriteLine("==============");

            //Predicate<Product> predicate = delegate (Product product)
            //{
            //    return product.Description.StartsWith("G");
            //};
            //Predicate<Product> predicate = p => p.Description.StartsWith("G");
            PrintProducts(p => p.Description.StartsWith("G"), p => Console.WriteLine($"{p.Description} begint met een G"));
            Console.WriteLine("==============");
            PrintProducts(
                p => p.Price > 50,
                p => Console.WriteLine($"{p.Description} kost {p.Price:C}")
            );

            var summary = products.Select(p => (Name: p.Description, IsCheap: p.Price < 30));

            Console.WriteLine(summary.Count());


            //Parallel.Invoke(
            //    () => { },
            //    () => { },
            //    () => { }
            //);
        }

        public static void PrintProducts(Predicate<Product> pred, Action<Product> printer)
        {
            foreach (var product in products)
            {
                if (pred(product))
                {
                    printer(product);
                }
            }
        }

        public static void PrintExpensiveProducts()
        {
            foreach (var product in products)
            {
                if (product.Price > 50m)
                {
                    Console.WriteLine($"{product.Description} kost {product.Price:C}");
                }
            }
        }

        public static void PrintProductsBeginningWithLetter(string letter)
        {
            foreach (var product in products)
            {
                if (product.Description.StartsWith(letter))
                {
                    Console.WriteLine($"{product.Description} begint met een {letter}");
                }
            }
        }


    }
    class Product
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
