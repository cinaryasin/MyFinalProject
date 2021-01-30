﻿using DataAccess.Abstract;
using Entities.ConCrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.ConCrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                //Oracle, Sql Server, Postgress, MongoDb  veri tabanlarından geliyormuş gibi simule ediypruz
                new Product{ProductId = 1, CategoryId =1, ProductName="Fincan", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId = 2, CategoryId =1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
                new Product{ProductId = 3, CategoryId =2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId = 4, CategoryId =2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product{ProductId = 5, CategoryId =2, ProductName="Mouse", UnitPrice=85, UnitsInStock=1},

            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {   //Linq - Language Integrated Query Kısa yoldan dolaşma
            //p=>p tektek dolaşmaya yarıyor forech gibi

            Product productToDelete;
            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);

            //Başka bir yol
            //Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            //_products.Remove(productToDelete);


            //Silme işleminin uzun yolu

            //Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == product.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}
            //_products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {   //Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId); Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul

            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
