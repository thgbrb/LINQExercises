using System;
using System.Linq;
using static Functions.FunctionsDefinition;
using static System.Console;

namespace Functions
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define a string arrays
            var numbers = new[] { "4", "2", "1", "7", "8", "9", "34", "10", };
          
            numbers
                .Select(str2int) // For each list element apply func str2int
                .ToList() // Create a new list
                .ForEach(Print); // For each element print it
        }
    }

    /// <summary>
    /// Functions
    /// </summary>
    public static class FunctionsDefinition
    {
        /// <summary>
        /// Convert string to int
        /// </summary>
        public static Func<string, int> str2int =
            (s) =>
            {
                int i;
                int.TryParse(s, out i);

                return i;
            };
        
        /// <summary>
        /// Format and print an string
        /// </summary>
        public static Action<int> Print =
            (s) => WriteLine($@"{s.GetType().Name} : {s.ToString()}");   
    }
}