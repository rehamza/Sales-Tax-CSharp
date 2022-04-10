using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using SalesTax.Tax;
using SalesTax.Shopping;

namespace SalesTax.Tax {
 class TaxCalculator
  {
    private Tax[] _Taxes = new Tax[] { new BasicTax(), new ImportedDutyTax() };

    public void Calculate(ShoppingCart shoppingCart)
    {
        foreach (var cartItem in shoppingCart.CartItems)
        {
            cartItem.Tax = _Taxes.Sum(x => x.Calculate(cartItem.Product));
        }
    }
  }
  
}