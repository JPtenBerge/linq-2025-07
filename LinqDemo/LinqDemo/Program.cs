// See https://aka.ms/new-console-template for more information


List<Product> products = new()
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



// LINQ SQL-ig  "comprehension syntax" - complexere dingen
var filteredProducts = from p
                       in products
                       where p.Description.StartsWith("S")
                       select p;
foreach (var product in filteredProducts)
{
    Console.WriteLine(product.Description);
}



var p2 = products.SingleOrDefault(x => x.Price > 270m);
Console.WriteLine(p2 is null);
Console.WriteLine(p2.Description);

// LINQ extension methods - simpelere dingen 👍
// .Where()
// .Select()
// .SelectMany()
// .OrderBy()
// .OrderByDescending()
// .All()
// .ToList()
// .Min()
// .Max()
// .Count()
// .Sum()


var lijstje = new List<int>();
lijstje.All(x => x > 50);

Console.WriteLine(lijstje.Count); // .Count is van List<T>
Console.WriteLine(lijstje.Count()); // LINQ extension method

IEnumerable<int> basaalLijstje = new int[3];
//basaalLijstje.Count()

// eentje selecteren:
// .First(x => x.Price > 100000000)  - pakt eerste die hij tegenkomt. niks gevonden? exception.
// .FirstOrDefault()  - pakt eerste die hij tegenkomt. niks gevonden? "de default value van dat type"
// .Single() - zelfde als First, maar checkt dan ook of dat het enige matchende element is. zo niet? exception.
// .SingleOrDefault()
// .Last()
// .LastOrDefault()


class Product
{
    public string Description { get; set; }
    public decimal Price { get; set; }
}

