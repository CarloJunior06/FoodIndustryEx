using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFactory.Products
{
    public interface IFood
    {
        public string name { get; set; }
        public float price { get; set; }
        public string description { get; set; }
        public string expirationDate { get; set; }
        public int productId { get; set; }

      
        void GetInfo();
    }
}
