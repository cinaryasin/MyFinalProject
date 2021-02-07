using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.ConCrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.ConCrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, NorthwindContext>, IOrderDal
    {
    }
}
