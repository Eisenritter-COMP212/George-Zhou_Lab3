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

            // LINQ
            var InvoiceTotal =
                from i in invoices
                orderby i.Quantity * i.Price
                select new { Invoice = i, InvoiceTotal = i.Quantity * i.Price };

            Console.WriteLine($"{"Part #",-10}{"Part Description",-20}{"Quantity",-10}{"Price",-10}{"Invoice Total",-10}");
            
            foreach (var i in InvoiceTotal)
            {
                Console.WriteLine(i.Invoice.ToString()+i.InvoiceTotal);
            }
            
            //InvoiceTotal.Display();
   
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
