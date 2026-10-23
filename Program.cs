using Assignment_02_LinqC_.DataSources;
using Assignment_02_LinqC_.Models;

namespace Assignment_02_LinqC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1

            var Top3products = Source.ProductList
                                .OrderByDescending(N => N.UnitPrice)
                                .Take(3);

            foreach (var product in Top3products)
                Console.WriteLine($"Product Name: {product.ProductName}, Unit Price: {product.UnitPrice}");

            #endregion

            
        }
    }
}
