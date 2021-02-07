using Business.Abstract;
using DataAccess.Abstract;
using Entities.ConCrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ConCrete
{
    public class CategoryManager:ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {   //İş kodları

            return _categoryDal.GetAll();

        }

        //Select * from Categories where CategoryId = 3 gibi
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
