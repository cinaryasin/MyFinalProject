using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext>:IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {


                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();


            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {


                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();


            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                   ? context.Set<TEntity>().ToList()
                   : context.Set<TEntity>().Where(filter).ToList();


            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {


                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();


            }
        }
    }
}

//EfCustomerDal, EfCategoryDal, EfProductDal içerisinde tanımladığımız kodları buraya aldık
//public void Add(Category entity)
//{
//    using (NorthwindContext context = new NorthwindContext())
//    {


//        var addedEntity = context.Entry(entity);
//        addedEntity.State = EntityState.Added;
//        context.SaveChanges();


//    }
//}

//public void Delete(Category entity)
//{
//    using (NorthwindContext context = new NorthwindContext())
//    {


//        var deletedEntity = context.Entry(entity);
//        deletedEntity.State = EntityState.Deleted;
//        context.SaveChanges();


//    }
//}

//public Category Get(Expression<Func<Category, bool>> filter)
//{
//    using (NorthwindContext context = new NorthwindContext())
//    {
//        return context.Set<Category>().SingleOrDefault(filter);
//    }
//}

//public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
//{
//    using (NorthwindContext context = new NorthwindContext())
//    {
//        return filter == null
//           ? context.Set<Category>().ToList()
//           : context.Set<Category>().Where(filter).ToList();


//    }
//}

//public void Update(Category entity)
//{
//    using (NorthwindContext context = new NorthwindContext())
//    {


//        var updatedEntity = context.Entry(entity);
//        updatedEntity.State = EntityState.Modified;
//        context.SaveChanges();


//    }
//}