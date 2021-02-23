using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //veri tabanında yapılacak operasyonları içerir - silme,güncelleme vs.
    public interface IProductDal : IEntityRepository<Product>
    {
    }
    
}
