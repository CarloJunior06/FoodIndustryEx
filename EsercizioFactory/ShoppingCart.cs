using FoodFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFactory
{
    internal class ShoppingCart
    {
        public List<IFood> items;

        public ShoppingCart()
        {
            items = new List<IFood>(); 
        }
        public void AddItem(IFood food)
        {
            items.Add(food);
            Console.WriteLine($"{food.name} has been added to the cart");
        }
        
        public void RemoveItem(IFood food)
        {
            items.Remove(food);
            Console.WriteLine($"{food.name} has been removed from the cart");
        }
        public float CalculateTotal()
        {
            float totalProducts = 0;
            Console.WriteLine("Items in the cart:");
            foreach (var item in items)
            {
                totalProducts += item.price;
                item.GetInfo();
            }
            return totalProducts;
        }
        public void ShowCart()
        {
            Console.WriteLine("Shopping Cart:");
            foreach (var item in items)
            {
                Console.WriteLine(item.name);
            }
            Console.WriteLine();
        }




    }

    //deve tracciare gli acquisti
    //deve avere metodi additem, removeitem, calculatetotal

}
