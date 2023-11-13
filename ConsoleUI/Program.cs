using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetProductDetails())
            {
                Console.WriteLine(item.ProductName+" / "+item.CategoryName);
            }
            Console.WriteLine("************************************");
            foreach (var item in productManager.GetByUnitPrice(20, 40))
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}