using Business.ConCrete;
using DataAccess.ConCrete.EntityFramework;
using DataAccess.ConCrete.InMemory;
using System;

namespace ConsoleUI
{//GitGüncel
    //soyutlar Absrack = bağımlılıklar minimize edilecek ,  somutlar Concrete
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }


            Console.WriteLine(" ******************************* ");
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine(customer.CompanyName);
            }


            Console.WriteLine(" ******************************* ");
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }
    }
}
