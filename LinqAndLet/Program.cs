using static System.Console;
using System.Linq;

namespace LinqAndLet
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 100);

            var result = from i in numbers
                         let x = i * 2
                         select x;

            result.ToList().ForEach(x => WriteLine(x.ToString()));
            
            ReadLine();
        }
    }
}