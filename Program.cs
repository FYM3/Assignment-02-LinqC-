using Assignment_02_LinqC_.DataSources;
using Assignment_02_LinqC_.Models;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

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

            //var Groupallproducts = Source.ProductList
            //                        .GroupBy(X => X.Category);

            //foreach (var group in Groupallproducts)
            //    Console.WriteLine($"Group {group.Key}: {group.Count()}");


            #endregion

            #region Q7

            //var Groupproducts = Source.ProductList
            //                    .GroupBy(X => X.Category)
            //                    .Select(X => new 
            //                    { Category = X.Key,
            //                      ProductNames = X.Select(X => X.ProductName)
            //                    });


            //foreach (var group in Groupproducts)
            //{
            //    Console.WriteLine($"Group {group.Category}::");

            //    foreach (var name in group.ProductNames)
            //        Console.WriteLine($"   {name}");
            //}

            #endregion

            #region Q8

            //var Finaallcategories = Source.ProductList
            //                        .GroupBy(X => X.Category)
            //                        .Select(X => new
            //                        {
            //                            Category = X.Key,
            //                            ProductName = X.Select(X => X.ProductName),
            //                            ProductCount = X.Count()
            //                        })
            //                        .Where(X => X.ProductCount > 3);


            //foreach (var group in Finaallcategories)
            //{
            //    Console.WriteLine($"Group {group.Category}::");

            //    foreach (var name in group.ProductName)
            //        Console.WriteLine($"   {name}");
            //}

            #endregion

            #region Q9

            //var CustomerGroups = from S in Source.CustomerList
            //                  group S by S.Country
            //                       into G
            //                  select new
            //                  {
            //                      Country = G.Key,
            //                      Count = G.Count(),
            //                      TotalOrderValue = G.SelectMany(C => C.Orders).Sum(O => O.Total)
            //                  };

            //foreach (var group in CustomerGroups)
            //{
            //    Console.WriteLine($"Country: {group.Country}");
            //    Console.WriteLine($"Count: {group.Count}");
            //    Console.WriteLine($"Total Order Value: {group.TotalOrderValue}");
            //}

            #endregion

            #region Q10

            //var TotalNumber = Source.ProductList.Sum(X => X.UnitsInStock);

            //Console.WriteLine($"Total number of units in stock: {TotalNumber}");

            #endregion

            #region Q11

            var MostEXPENSIVE = Source.ProductList.Max(X => X.UnitPrice);
            var MostCHEAPEST = Source.ProductList.Min(X => X.UnitPrice);

            Console.WriteLine($"Most Expensive Product: {MostEXPENSIVE}");
            Console.WriteLine($"Most Cheapest Product: {MostCHEAPEST}");

            #endregion
        }
    }
}
