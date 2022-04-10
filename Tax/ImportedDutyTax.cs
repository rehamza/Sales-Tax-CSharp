using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using SalesTax.Tax;
using SalesTax.Product;

namespace SalesTax.Tax{
 class ImportedDutyTax : Tax
  {
    public override bool IsApplicable(SalesProduct item)
    {
        return item.IsImported;
    }

    public override decimal Rate { get { return 5.00M; } }
  }
  
}