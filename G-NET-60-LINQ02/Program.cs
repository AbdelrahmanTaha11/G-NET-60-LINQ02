namespace G_NET_60_LINQ02;

using System.Diagnostics.Metrics;
using static G_NET_60_LINQ02.Source;

    internal class Program
    {
        static void Main(string[] args)
    {

        #region Question01
        //1. Get top 3 most expensive products

        //    var top = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);

        //foreach (var item in top)
        //{
        //    Console.WriteLine(item);
        //}




        #endregion

        #region Question02 

        //2. show page 2 of products, with page size = 5

        //var pageSize = 5;
        //var pageNumber = 2;
        //var products = ProductList.Skip((pageNumber - 1) * pageSize).Take(pageSize);

        //foreach (var item in products)
        //{
        //    Console.WriteLine(item);
        //}



        #endregion

        #region Question03
        //3. Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).
        //var products = ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);

        //foreach (var item in products)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region Question04

        //Check if ALL products in the "Seafood" category are in stock

        //var allInStock = ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);

        //Console.WriteLine(allInStock);

        #endregion

        #region Question05
        //5. Check if the ID list contains 9

        //var idList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //var containsNine = idList.Contains(9); 
        //var containsten = idList.Contains(10); 


        //Console.WriteLine(containsNine); //true
        //Console.WriteLine(containsten); //false  





        #endregion

        //معلش مخدش بالي من الليستا اللي انتو كاتبنها بس هي هي نفس الفكرة  Q 05  :)

        #region Question06
        // 6.Group all products by Category and print each group with its product count.

        //var GroupProduct = ProductList.GroupBy(P => P.Category)
        //                              .Select(g => new { g.Key, ProductCount = g.Count() });

        //foreach (var group in GroupProduct)
        //{
        //    Console.WriteLine(group);
        //}

        #endregion

        #region Question07
        //7. Group products by Category and project only product names per group.

        //var GroupProductNames = ProductList.GroupBy(p => p.Category)
        //                                 .Select(g => new { g.Key, ProductNames = g.Select(p => p.ProductName) });

        //foreach (var group in GroupProductNames)
        //{
        //    Console.WriteLine($"Category: {group.Key}");
        //    foreach (var productName in group.ProductNames)
        //    {
        //        Console.WriteLine($" - {productName}");
        //    }
        //}


        #endregion

        #region Question08
        //8. Find all categories that have MORE THAN 3 products

        //var categoriesWithMoreThanThreeProducts = ProductList.GroupBy(p => p.Category)
        //    .Where(g => g.Count() > 3)
        //    .Select(g => g.Key);

        //foreach (var category in categoriesWithMoreThanThreeProducts)
        //{

        //    Console.WriteLine(category);
        //}


        #endregion

        #region Question09
        //9. Using QUERY SYNTAX, group customers by Country, and for each  group select { Country, Count, TotalOrderValue }.

        //var customerGroups = from customer in CustomerList
        //                     group customer by customer.Country into countryGroup
        //                     select new
        //                     {
        //                         Country = countryGroup.Key,
        //                         Count = countryGroup.Count(),
        //                         TotalOrderValue = countryGroup.Sum(c => c.Orders.Sum(o => o.Total))
        //                     };
        //foreach (var group in customerGroups)
        //{
        //    Console.WriteLine(group);
        //}
        #endregion

        #region Question10

        // 10. Calculate the total number of units in stock across all products
        //var totalUnitsInStock = ProductList.Sum(p => p.UnitsInStock);

        //Console.WriteLine($"Total units in stock: {totalUnitsInStock}");

        #endregion

        #region Question11

        //11. Find the CHEAPEST and MOST EXPENSIVE product prices

        //var cheapestProduct = ProductList.Min(p => p.UnitPrice);
        //var mostExpensiveProduct = ProductList.Max(p => p.UnitPrice);

        //Console.WriteLine($"Cheapest product price: {cheapestProduct}");
        //Console.WriteLine($"Most expensive product price: {mostExpensiveProduct}");

        #endregion





    }
}

