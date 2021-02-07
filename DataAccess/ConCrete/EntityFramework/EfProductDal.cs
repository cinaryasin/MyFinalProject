using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.ConCrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.ConCrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock

                             };
                return result.ToList();
            }


            
        }
    }
}





//public void Add(Product entity) bunların hepsini EfEntityReposiyoryBase e aldık ve generic haline getirdik
//{
//    //buranın dışındada newlesek oluyor fakat bu daha performanslı bir çözüm
//    //IDisposable pattern implementation of C#
//    //garbrage collector e gel burayı topla diyor
//    using (NorthwindContext context = new NorthwindContext())
//    {

//        //git gönderdiğim veri kaynağında verdiğim nesneye eşleştir
//        var addedEntity = context.Entry(entity);
//        addedEntity.State = EntityState.Added;
//        context.SaveChanges();

//        //Yaptığımız işlemler referansı yakala, ekle , kaydet.
//    }
//}

//public void Delete(Product entity)
//{
//    using (NorthwindContext context = new NorthwindContext())
//    {

//        //git gönderdiğim veri kaynağında verdiğim nesneye eşleştir
//        var deletedEntity = context.Entry(entity);
//        deletedEntity.State = EntityState.Deleted;
//        context.SaveChanges();

//        //Yaptığımız işlemler referansı yakala, sil , kaydet.
//    }
//}

//public Product Get(Expression<Func<Product, bool>> filter)
//{
//    using (NorthwindContext context = new NorthwindContext())
//    {
//        return context.Set<Product>().SingleOrDefault(filter);
//    }
//}

//public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
//{
//    using (NorthwindContext context = new NorthwindContext())
//    {
//        return filter == null
//           ? context.Set<Product>().ToList()
//           : context.Set<Product>().Where(filter).ToList();


//    }

//}

//public void Update(Product entity)
//{
//    using (NorthwindContext context = new NorthwindContext())
//    {

//        //git gönderdiğim veri kaynağında verdiğim nesneye eşleştir
//        var updatedEntity = context.Entry(entity);
//        updatedEntity.State = EntityState.Modified;
//        context.SaveChanges();

//        //Yaptığımız işlemler referansı yakala, güncelle , kaydet.
//    }
//}