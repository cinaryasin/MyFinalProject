using Business.ConCrete;
using DataAccess.ConCrete.InMemory;
using System;

namespace ConsoleUI
{
    //soyutlar Absrack = bağımlılıklar minimize edilecek ,  somutlar Concrete
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            
        }
    }
}
