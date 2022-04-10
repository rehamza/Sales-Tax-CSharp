using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using  SalesTax.Shopping;

namespace SalesTax.Receipt {

 class ReceiptPrinter
  {
    public static void Print(ShoppingCart shoppingCart)
    {
        Console.WriteLine("output-------");
        foreach (var cartItem in shoppingCart.CartItems)
        {
            Console.WriteLine(cartItem.ToString());
        }

  
        Console.WriteLine("Taxes: {0:N2}", shoppingCart.TotalTax);

       
        Console.WriteLine("Total: {0:N2}", shoppingCart.TotalCost);
    }
  }
  
}
