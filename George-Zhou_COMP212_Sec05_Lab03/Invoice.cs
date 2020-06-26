using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace George_Zhou_COMP212_Sec05_Lab03
{
    class Invoice
    {
        // Properties  
        public int PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        // Constructor
        public Invoice(int partNumber, string partDescription, int quantity, decimal price)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            Price = price;
        }

       public override string ToString() => $"{PartNumber,-10}{PartDescription,-20}{Quantity,-10}{Price,-10:C}";
    }
}