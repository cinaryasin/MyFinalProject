using Business.Abstract;
using DataAccess.Abstract;
using Entities.ConCrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ConCrete
{
    public class CustomerManager:ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public List<Customer> GetAll()
        {   //İş kodları

            return _customerDal.GetAll();

        }
    }
}
