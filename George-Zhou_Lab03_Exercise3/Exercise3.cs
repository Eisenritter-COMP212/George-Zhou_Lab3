using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace George_Zhou_Lab03_Exercise3
{
    class Exercise3
    {
        static void Main(string[] args)
        {
            List<int> generatedList = GenerateList(10);
            Console.WriteLine("The generated list is:");
            generatedList.Display();
            Console.WriteLine();
            Console.WriteLine("Sorted with Values > 50 adding 10:");
            // Values greater than 50 , add 10 and then sorted 
            generatedList.Where(value => value > 50 ) // All values that are greater than 50
                .Select(value => value+10) // Adds 10 to each value
                .OrderBy(value => value)   // Sort the Values
                .Display();
        }

        // Generate a list of random integers depending on how many elements
        static List<int> GenerateList(int num)
        {
            Random rnd = new Random();
            var intList = new List<int>();
            for (int i = 0; i<num; i++)
            {
                intList.Add(rnd.Next(1, 100));
            }
            return intList;
        }
    }

    static class Extensions
    {
        // extension method that displays all elements separated by spaces
        public static void Display<T>(this IEnumerable<T> data)
        {
            Console.WriteLine(string.Join(" ", data));
        }
    }
}
