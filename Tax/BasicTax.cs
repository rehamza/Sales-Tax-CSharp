using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using SalesTax.Tax;
using SalesTax.Product;

namespace SalesTax.Tax{
 class BasicTax : Tax
  {
    private ProductType[] _taxExcemptions = new[] { ProductType.Food, ProductType.Medical, ProductType.Book };

    public override bool IsApplicable(SalesProduct item)
    {
        return !(_taxExcemptions.Any(x => item.IsTypeOf(x)));
    }

    public override decimal Rate { get { return 10.00M; } }
  }
  
}