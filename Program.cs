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

            //var MostEXPENSIVE = Source.ProductList.Max(X => X.UnitPrice);
            //var MostCHEAPEST = Source.ProductList.Min(X => X.UnitPrice);

            //Console.WriteLine($"Most Expensive Product: {MostEXPENSIVE}");
            //Console.WriteLine($"Most Cheapest Product: {MostCHEAPEST}");

            #endregion

            #region Q12

            //var Allproduct = Source.ProductList
            //                .Select(X => X.Category)
            //                .Distinct();


            //foreach (var product in Allproduct)
            //    Console.WriteLine($"Category: {product}");

            #endregion

            #region Q13

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var onlyInA = setA.Except(setB);

            //Console.WriteLine($"Elements only in set A: {string.Join(", ", onlyInA)}");

            #endregion

            #region Q14

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var onlyInA = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            //Console.WriteLine($"Elements only in set A: {string.Join(", ", onlyInA)}");

            #endregion

            #region Q15

            //Dictionary<int, Product> pairs = Source.ProductList.ToDictionary(p => p.ProductID);

            //Console.WriteLine($"Product ID: {pairs[18].ProductID}, Product Name: {pairs[18].ProductName}, Category: {pairs[18].Category}");

            #endregion

            #region Q16

            //var Firstproduct = Source.ProductList.FirstOrDefault(X => X.UnitPrice > 50);

            //Console.WriteLine($"First product with unit price > 50: {Firstproduct?.ProductName ?? "Not found"}");

            #endregion

            #region Q17

            //var Firstproduct = Source.ProductList.FirstOrDefault(X => X.UnitPrice > 500);

            //Console.WriteLine($"First product with unit price > 500: {Firstproduct?.ProductName ?? "Not found"}");

            #endregion

            #region Q18

            //var Table = Enumerable.Range(1, 10).Select(X => $"7 x {X} = {7 * X}");

            //foreach (var item in Table)
            //    Console.WriteLine(item);

            #endregion

            #region Q19

            //var EvenNumbers = Enumerable.Range(1, 30).Where(X => X % 2 == 0);

            //foreach (var number in EvenNumbers)
            //    Console.WriteLine(number);

            #endregion

        }
    }
}
