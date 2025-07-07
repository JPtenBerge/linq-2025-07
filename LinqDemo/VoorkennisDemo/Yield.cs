using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoorkennisDemo;

class Yield
{
    public static void Werk()
    {
        //foreach (var getal in GeefGetallen())
        //{
        //    Console.WriteLine(getal);
        //}

        // deferred execution

        var source = GeefGetallen();
        var enumerator = source.GetEnumerator();
        enumerator.MoveNext();
        enumerator.MoveNext();
        enumerator.MoveNext();
    }

    public static IEnumerable<int> GeefGetallen()
    {
        Console.WriteLine("eerste");
        yield return 4;
        Console.WriteLine("tweede");
        yield return 8;
        Console.WriteLine("derde");
        yield return 15;
        Console.WriteLine("vierde");
        yield return 16;
        Console.WriteLine("vijfde");
        yield return 23;
        Console.WriteLine("zesde");
        yield return 42;
    }
}
