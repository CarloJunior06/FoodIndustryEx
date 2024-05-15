using FoodFactory.Exceptions;
using FoodFactory.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FoodFactory
{
    public class FoodFactory 
    {
        public static IFood Get(int productId)
        {
            if (productId == 0) return new Fruit ("Pear", 2.50f, "Sweet fruit", "Expiring in 20/05/2024", 0);
            if (productId == 1) return new Fruit("Orange", 1.50f, "Sour fruit", "Expiring in 20/05/2024", 1);
            if (productId == 2) return new Fruit("Apple", 1.70f, "Healty fruit", "Expiring in 20/05/2024", 2);
            if (productId == 3) return new Vegetables("Salad", 1.00f, "Fresh vegetable", "Expiring in 18/05/2024", 3);
            if (productId == 4) return new Vegetables("Spinach", 2.00f, "Bitter vegetable", "Expiring in 17/05/2024", 4);
            if (productId == 5) return new Vegetables("Onion", 0.80f, "Sour vegetable", "Expiring in 20/05/2024", 5);
            if (productId == 6) return new Meat("T Bone Beef", 25.00f, "A large piece of Meat", "Expiring in 17/05/2024", 6);
            if (productId == 7) return new Meat("Chicken", 6.50f, "Chicken Breast Meat", "Expiring in 16/05/2024", 7);
            if (productId == 8) return new Meat("Pulled Pork", 13.00f, "Pork Meat", "Expiring in 16/05/2024", 8);
            

            {
                
            }
            throw new ProductIdNotFoundException(productId);
        }

    }
}
