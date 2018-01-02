using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace LinqIntersections
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var listA = new int[] { 1, 2, 3, 4, 5 };
            var listB = new int[] { 4, 5, 6, 7, 8 };

            var intersectAB = listA.Intersect(listB);

            var intersectBA = listB.Intersect(listA);

            var exceptAB = listA.Except(listB);

            var exceptBA = listB.Except(listA);

            var symetric = listA
                .Except(listB)
                .Union(
                    second: listB
                    .Except(listA));

            var hashSet = new HashSet<int>(listA);
            hashSet.SymmetricExceptWith(listB);

            WriteLine("Intersection A -> B");
            intersectAB
                .ToList()
                .ForEach(action: WriteLine);

            WriteLine("Intersection B -> A");
            intersectBA
                .ToList()
                .ForEach(action: WriteLine);

            WriteLine("Intersection Except A -> B");
            exceptAB
                .ToList()
                .ForEach(action: WriteLine);

            WriteLine("Intersection Except B -> A");
            exceptBA
                .ToList()
                .ForEach(action: WriteLine);

            WriteLine("Symetric");
            symetric
                .ToList()
                .ForEach(action: WriteLine);

            WriteLine("Symetric with hashset");
            hashSet
                .ToList()
                .ForEach(action: WriteLine);

            ReadLine();
        }
    }
}