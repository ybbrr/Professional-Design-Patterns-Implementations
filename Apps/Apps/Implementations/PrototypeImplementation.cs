
using DesignPatterns.Prototype;

namespace Apps.Implementations
{
    public static class PrototypeImplementation
    {
        public static void Prototype_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nPrototype Design Pattern\n");

            Customer customer1 = new Customer
            {
                FirstName = "John", LastName = "Doe", City = "Newyork", Id = 1
            };

            Customer customer2 = (Customer)customer1.Clone();
            customer2.FirstName = "Jane";

            Console.WriteLine("Customer 1 Name : " + customer1.FirstName);
            Console.WriteLine("Customer 2 Name : " + customer2.FirstName);

            /*
              * Burada ikinci nesne birinci nesnden klonlanmıştır ve kesinlikle customer1'deki bilgileri taşıyan yeni bir nesnedir.
                Klonlanan nesnenin referansını customer2'ye verip FirstName property'sini değiştirdiğimizde customer1'deki FirstName
                property'sinin değişmediği görülmektedir.
            */

            Console.WriteLine("\n**************************************************");
        }
    }
}
