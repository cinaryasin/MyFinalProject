using Entities.ConCrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
    }
}
