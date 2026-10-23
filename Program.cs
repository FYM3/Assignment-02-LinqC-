using Assignment_02_LinqC_.DataSources;
using Assignment_02_LinqC_.Models;

namespace Assignment_02_LinqC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1

            //var Top3products = Source.ProductList
            //                    .OrderByDescending(N => N.UnitPrice)
            //                    .Take(3);

            //foreach (var product in Top3products)
            //    Console.WriteLine($"Product Name: {product.ProductName}, Unit Price: {product.UnitPrice}");

            #endregion

            #region Q2

            //var Page2ofproducts = Source.ProductList
            //                    .OrderBy(X => X.ProductName).Skip((2 - 1) * 5)
            //                    .Take(5);

            //foreach (var product in Page2ofproducts)
            //    Console.WriteLine($"Product Name: {product.ProductName}, Unit Price: {product.UnitPrice}");

            #endregion

            #region Q3

            var ProductsLess25 = Source.ProductList
                                    .OrderBy(X => X.UnitPrice)
                                    .TakeWhile(X => X.UnitPrice < 25);

            foreach (var product in ProductsLess25)
                Console.WriteLine($"Product Name: {product.ProductName}, Unit Price: {product.UnitPrice}");

            #endregion

        }
    }
}
