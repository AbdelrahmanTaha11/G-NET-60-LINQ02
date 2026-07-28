namespace G_NET_60_LINQ02;
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



    }
}

