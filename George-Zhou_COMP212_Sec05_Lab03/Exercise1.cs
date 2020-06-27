using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace George_Zhou_COMP212_Sec05_Lab03
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            // Creates array of invoice objects
            var invoices = new[]
            {
                new Invoice(87,"Electric Sander",7,(decimal)57.98),
                new Invoice(24,"Power Saw",18,(decimal)99.99),
                new Invoice(7,"Sledge Hammer",11,(decimal)21.50),
                new Invoice(77,"Hammer",76,(decimal)11.99),
                new Invoice(39,"Lawn Mower",3,(decimal)79.50),
                new Invoice(68,"Screw Driver",106,(decimal)6.99),
                new Invoice(56,"Jig saw",21,(decimal)11.00)

            };

            // LINQ Query 1A
            try { 
            var InvoiceTotal =
                from i in invoices
                let invoiceTotal = i.Quantity * i.Price
                orderby invoiceTotal
                select new { Invoice = i, InvoiceTotal = i.Quantity * i.Price };
            Console.WriteLine($"{"Part #",-10}{"Part Description",-20}{"Quantity",-10}{"Price",-10}{"Invoice Total",-10}");

                // Display Exercise 1A Result
                foreach (var i in InvoiceTotal) { Console.WriteLine($"{i.Invoice}{i.InvoiceTotal:C}"); }
            }
            catch(Exception e)
            {

            }

            // LINQ Query 1B
            try
            {
                int max = invoices.Max(i => i.Quantity);
                var Maximum = invoices.First(x => x.Quantity == max);
                // Display Exercise 1B Result
                Console.WriteLine($"The invoices with the most quantity is {Maximum.PartDescription}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // LINQ Query 1C
            try
            {
                var average = invoices.Average(x => x.Price);
                Console.WriteLine($"The average price of the parts is {average:C}");                 
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
    // declares an extension method 
    static class Extensions
    {
        // extension method that displays all elements separated by spaces
        public static void Display<T>(this IEnumerable<T> data)
        {
            Console.WriteLine(string.Join(" \n", data));
        }
    }
}
