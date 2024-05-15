using FoodFactory.Exceptions;
using FoodFactory.Products;

namespace FoodFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowProductList();
            ShoppingCart cart = new ShoppingCart();
            while (true)
            {
                Console.WriteLine("Enter the product code to add it to the cart (or 'done' to finish):");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "done")
                    break;
                else
                {
                    try
                    {
                        int productId = int.Parse(userInput);
                        IFood product = FoodFactory.Get(productId);
                        cart.AddItem(product);
                    }
                    catch (ProductIdNotFoundException ex)
                    {

                        Console.WriteLine($"Error, entered ID is invalid: {ex.ProductId}");
                    }
                }
            }
            cart.ShowCart();
            while (true)
            {


                Console.WriteLine("Enter the product code to remove it from the cart (or 'done' to finish shopping):");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "done")
                    break;
                else
                {
                    try
                    {
                        int productId = int.Parse(userInput);
                        var itemToRemove = cart.items.FirstOrDefault(item => item.productId == productId);
                        if (itemToRemove != null)
                        {
                            cart.RemoveItem(itemToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Product not found in the cart.");
                        }
                    }
                    catch (ProductIdNotFoundException ex)
                    {

                        Console.WriteLine($"Error, entered ID is invalid: {ex.ProductId}");
                    }
                }           
            }
            float total = cart.CalculateTotal();
            Console.WriteLine($"Total amount to pay: {total}");

            static void ShowProductList()
            {
                Console.WriteLine("Product List:");
                Console.WriteLine("0: Pear");
                Console.WriteLine("1: Orange");
                Console.WriteLine("2: Apple");
                Console.WriteLine("3: Salad");
                Console.WriteLine("4: Spinach");
                Console.WriteLine("5: Onion");
                Console.WriteLine("6: T Bone Beef");
                Console.WriteLine("7: Chicken");
                Console.WriteLine("8: Pulled Pork");
                Console.WriteLine();
            }
        }
    }
}
