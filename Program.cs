using System;

namespace MaxandMinUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Minumum F1 = new Minumum();
             F1.FindMinimum(21,34,78);
             F1.FindMinimum2(23.4,43.6,12.5);
             F1.FindMinimum3("vamshi","sai","rahul");*/

            MinumunUsingGenerics minumum = new MinumunUsingGenerics();
            minumum.FindMinimum(21, 34, 78);
            minumum.FindMinimum(23.4, 43.6, 12.5);
            minumum.FindMinimum("vamshi", "sai", "rohith");
        }
    }
}
