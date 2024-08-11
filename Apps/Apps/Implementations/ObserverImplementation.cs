using DesignPatterns.Observer;

namespace Apps.Implementations
{
    public static class ObserverImplementation
    {
        public static void Observer_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nObserver Design Pattern\n");

            ProductManager productManager = new ProductManager();
            CustomerObserver customerObserver = new CustomerObserver();
            EmployeeObserver employeeObserver = new EmployeeObserver();
            productManager.Attach(customerObserver);
            productManager.Attach(employeeObserver);
            //productManager.Detach(customerObserver); //uncomment to see detacth operation
            productManager.UpdatePrice();

            Console.WriteLine("\n**************************************************");
        }
    }
}
