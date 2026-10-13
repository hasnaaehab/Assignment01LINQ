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
        }
    }
}
