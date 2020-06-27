using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace George_Zhou_Lab03_Exercise5
{
    class Exercise5
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int[] values = Enumerable.Range(1, 10000000)
                .Select(x => rnd.Next(1, 500))
                .ToArray();

            Console.WriteLine("Min, Max and Average with LINQ to Objects using a single core");
            var linqStart = DateTime.Now; // get time before method calls
            var linqSum = values.Sum(x=>Convert.ToInt64(x)); // Nomral Linq Sum
            var linqDistinctCount = values.Distinct().Count(); // Normal Linq Distinct
            var linqEnd = DateTime.Now; // get time after method calls

            // display results and total time in milliseconds
            var linqTime = linqEnd.Subtract(linqStart).TotalMilliseconds;
            DisplayResults(linqSum, linqDistinctCount,linqTime);

            // time the Min, Max and Average PLINQ extension methods
            Console.WriteLine(
               "\nMin, Max and Average with PLINQ using multiple cores");
            var plinqStart = DateTime.Now; // get time before method calls
            var plinqSum = values.AsParallel().Sum(x => Convert.ToInt64(x));
            var plinqDistinct = values.AsParallel().Distinct().Count();
            var plinqEnd = DateTime.Now; // get time after method calls

            // display results and total time in milliseconds
            var plinqTime = plinqEnd.Subtract(plinqStart).TotalMilliseconds;
            DisplayResults(plinqSum, plinqDistinct, plinqTime);

            // display time difference as a percentage
            Console.WriteLine("\nPLINQ took " +
               $"{((linqTime - plinqTime) / linqTime):P0}" +
               " less time than LINQ");
        }

        // displays results and total time in milliseconds
        static void DisplayResults(
           long sum, int distinctCount, double time)
        {
            Console.WriteLine($"Sum: {sum}\nNumber of distinct values: {distinctCount}\n" +
                $"\nTotal time in milliseconds: {time:F}");
        }
    }
}
