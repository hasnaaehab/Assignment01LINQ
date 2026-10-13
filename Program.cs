using LINQ.Models;
using System.Collections;
using static LINQ.DataSources.Source;
namespace Assignment01LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Question 1 
            //var seafoodproducts = ProductList.Where(p => p.Category == "Seafood").Select(x => new { x.ProductName , x.UnitPrice}); 
            //foreach (var product in seafoodproducts)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Question 2
            //var productNames = ProductList.Select(p => p.ProductName);
            //foreach (var productName in productNames)
            //{
            //    Console.WriteLine(productName);
            //}
            #endregion

            #region Question 3
            //var ProudctsBetween10and20 = ProductList.Where(p => p.UnitPrice>= 10 && p.UnitPrice <=20);
            //foreach (var product in ProudctsBetween10and20)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion


            #region Question 4
            //var CondimentsInstockproducts = ProductList.Where(p => p.Category == "Condiments" && p.UnitsInStock>0);
            //foreach (var product in CondimentsInstockproducts)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Question 5
            //var productDto = ProductList.Select(p => new
            //{

            //    p.ProductName,
            //    p.UnitPrice,
            //    StockkStatus = (p.UnitsInStock > 0) ? "Available" : "Out of Stock"
            //});

            //foreach (var product in productDto)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Question 6
            //var indexedonebasedproducts = ProductList.Select((p, index) => new
            //{

            //    Index = index + 1,
            //    p.ProductName
            //});

            //foreach (var product in indexedonebasedproducts)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
        }
    }
}