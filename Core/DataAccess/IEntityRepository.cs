using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    /*generic constraint  = generic kısıtlaması yapma where T: class vb. 
    class referans tip olabilir.
    IEntity = IEntity olabilir yada IEntityden implement olabilir.
    new() = new lenebilir olmalı  , IEntity newlenemediği için elimizde category, customer, 
    product kalıyor ve Iproduct, Icustomer, Icategory de sadece sınıflar generik içerisine yazılabilir.
    
    */
    
    public interface IEntityRepository<T> where T:class,IEntity,new()                //where ile generic yapılara belirli sınırlamalar yerleştiriyoruz
    {   //=nul vermeyedebilirsin anlamında kullanılır.
        //Filtreleme için Expression kullanılır.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        //Detaylara gitmek için
        T Get(Expression<Func<T, bool>> filter);

        
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);




        //List<T> GetAllByCategory(int categoryId); Filtreleme sayesinde bu koda ihtiyacımız kalmıyor
    }
}
