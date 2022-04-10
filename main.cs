using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using SalesTax.Items;
using  SalesTax.Tax;
using SalesTax.Receipt;

namespace SalesTax
{
    class Program
    {
        public static void Main(string[] args)
        {
            var input1 = new[]
          {
            "1 book at 12.49",
            "1 music CD at 14.99",
            "1 chocolate bar at 0.85"
        };

            var input2 = new[]
            {
            "1 imported box of chocolates at 10.00",
            "1 imported bottle of perfume at 47.50"
        };

            var input3 = new[]
            {
            "1 imported bottle of perfume at 27.99",
            "1 bottle of perfume at 18.99",
            "1 packet of headache pills at 9.75",
            "1 box of imported chocolates at 11.25"
        };
            Console.WriteLine("input1-------");
            InputResut(input1);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("input2-------");
            InputResut(input2);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("input3-------");
            InputResut(input3);
            Console.WriteLine("--------------------------------------------------");
        }

        private static void InputResut(string[] input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
          

            var shoppingCart = ItemsParser.Parse(input);

            var taxCalculator = new TaxCalculator();
            taxCalculator.Calculate(shoppingCart);

            ReceiptPrinter.Print(shoppingCart);
        }
    }

}
