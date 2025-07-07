using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoorkennisDemo
{
    class AnonTypes
    {
        public static void Doe()
        {
            var obj = new
            {
                x = 24,
                y = "hoi",
                z = 134
            };

            //obj.y = 21345;
            // JSON

            var bla = new List<object>();
            bla.Select(x => new
            {

            });

            // EF Core - Fluent API
            //onmodelconfiguring() {
            //    modelBuilder.Entity<Product>().HasKey(x => new { x.ProductId, x.Price });
            //}

            // tuples?


            var mijnLelijkeOuderwetseTuple = new Tuple<int, int, string>(4, 8, "hoi");


            var betereTuple = (4, 8, "hoi");
            Console.WriteLine($"{betereTuple.Item1}");
            Console.WriteLine($"{betereTuple.Item3}");


            var (eerste, tweede, tekstje) = (4, 8, "hoi");
            Console.WriteLine($"{eerste}");

            var (getalletje, tekst) = GeefTuple();
            Console.WriteLine(tekst);
            
            
            var tupleResult = GeefTuple();
            Console.WriteLine(tupleResult.Item2);
            Console.WriteLine(tupleResult.Tekst);

        }

        public static (int Getal, string Tekst) GeefTuple()
        {
            return (42, "wauw!");
        }
    }
}
