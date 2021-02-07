using Business.Abstract;
using DataAccess.Abstract;
using Entities.ConCrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ConCrete
{
    
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
       

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }
    }
}
