
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

enum ProductType
{
    Food,
    Medical,
    Book,
    Other
}
namespace SalesTax.Product {
class SalesProduct
{

    private static readonly IDictionary<ProductType, string[]> itemType_Identifiers = new Dictionary<ProductType, string[]>
    {
        {ProductType.Food, new[]{ "chocolate", "chocolates" }},
        {ProductType.Medical, new[]{ "pills" }},
        {ProductType.Book, new[]{ "book" }}
    };

    public decimal ShelfPrice { get; set; }

    public string Name { get; set; }

    public bool IsImported { get { return Name.Contains("imported "); } }

    public bool IsTypeOf(ProductType productType)
    {
        return itemType_Identifiers.ContainsKey(productType) &&
            itemType_Identifiers[productType].Any(x => Name.Contains(x));
    }

    public override string ToString()
    {
        return string.Format("{0} at {1}", Name, ShelfPrice);
    }

}

}