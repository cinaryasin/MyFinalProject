using Business.ConCrete;
using DataAccess.ConCrete.EntityFramework;
using DataAccess.ConCrete.InMemory;
using System;

namespace ConsoleUI
{   //Data Transformation Object Entitieste oluşturduğumuz DTOs klasörü = Taşınacak objeler
    //Code Refactoring = kodun iyileştirilmesi
    //soyutlar Absrack = bağımlılıklar minimize edilecek ,  somutlar Concrete
    class Program
    {
        static void Main(string[] args)
        {
            ProductMetot();
            //CustomerMetot();
            //CategoryMetot();
            //OrderMetot();
        }

        private static void OrderMetot()
        {
            Console.WriteLine(" ***************Order**************** ");
            OrderManager orderManager = new OrderManager(new EfOrderDal());
            foreach (var order in orderManager.GetAll())
            {
                Console.WriteLine(order.OrderId);
            }
        }

        private static void CategoryMetot()
        {
            Console.WriteLine(" **************Category***************** ");
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void CustomerMetot()
        {
            Console.WriteLine(" **************Customer***************** ");
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine(customer.CompanyName);
            }
        }

        private static void ProductMetot()
        {
            Console.WriteLine(" **************Product***************** ");
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in productManager.GetProductDetails().Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName );
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
