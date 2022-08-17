using System;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var modifyPrice = new ModifyPrice();
            var product = new Product("Phone", 500);
            Execute(modifyPrice, new ProductCommand(product, PriceAction.Increase, 100));

            Execute(modifyPrice, new ProductCommand(product, PriceAction.Increase, 50));
            Execute(modifyPrice, new ProductCommand(product, PriceAction.Decrease, 25));
            Console.WriteLine(product);
        }
        private static void Execute(ModifyPrice modifyPrice, ICommand productCommand)
        {
            modifyPrice.SetCommand(productCommand);
            modifyPrice.Invoke();
        }
    }
}
