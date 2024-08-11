using DesignPatterns.Command;

namespace Apps.Implementations
{
    public static class CommandImplementation
    {
        public static void Command_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nCommand Design Pattern\n");

            StockManager stockManager = new StockManager();
            BuyStock buyStock = new BuyStock(stockManager);
            SellStock sellStock = new SellStock(stockManager);

            StockController stockController = new StockController();
            stockController.TakeOrder(buyStock);
            stockController.TakeOrder(sellStock);
            stockController.TakeOrder(buyStock);

            stockController.PlaceOrders();

            Console.WriteLine("\n**************************************************");
        }
    }
}
