using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetAllByCategoryId(3))
            {
                Console.WriteLine(item.ProductName);
            }
            Console.WriteLine("************************************");
            foreach (var item in productManager.GetByUnitPrice(20,40))
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}