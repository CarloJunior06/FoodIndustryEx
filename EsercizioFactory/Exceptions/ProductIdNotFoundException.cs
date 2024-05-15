using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFactory.Exceptions
{
    public class ProductIdNotFoundException : Exception
    {
        public int ProductId { get;}

        public ProductIdNotFoundException(int productId)
        {
            ProductId = productId;
        }
    }
}
