using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using SalesTax.Product;

namespace SalesTax.Tax {
 abstract class Tax
  {
    abstract public bool IsApplicable(SalesProduct item);
    abstract public decimal Rate { get; }

    public decimal Calculate(SalesProduct item)
    {
        if (IsApplicable(item))
        {
        
            var tax = (item.ShelfPrice * Rate) / 100;

            tax = Math.Ceiling(tax / 0.05m) * 0.05m;

            return tax;
        }

        return 0;
    }
  }
  
}