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

            //var ProductsLess25 = Source.ProductList
            //                        .OrderBy(X => X.UnitPrice)
            //                        .TakeWhile(X => X.UnitPrice < 25);

            //foreach (var product in ProductsLess25)
            //    Console.WriteLine($"Product Name: {product.ProductName}, Unit Price: {product.UnitPrice}");

            #endregion

            #region Q4

            //var Allproducts = Source.ProductList
            //                        .Where(X => X.Category == "Seafood")
            //                        .All(X => X.UnitsInStock > 0);

            //Console.WriteLine($"All products are seafood and in stock: {Allproducts}");

            #endregion

            #region Q5

            //int[] ids = { 3, 9, 13, 18 };

            //if (ids.Contains(9))
            //    Console.WriteLine("Is Found");
            //else
            //    Console.WriteLine("Can't Find");

            #endregion

            #region Q6

            var Groupallproducts = Source.ProductList
                                    .GroupBy(X => X.Category);

            foreach (var group in Groupallproducts)
                Console.WriteLine($"Group {group.Key}: {group.Count()}");


            #endregion
        }
    }
}
