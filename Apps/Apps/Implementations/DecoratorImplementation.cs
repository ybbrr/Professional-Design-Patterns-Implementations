using DesignPatterns.Decorator;

namespace Apps.Implementations
{
    public static class DecoratorImplementation
    {
        public static void Decorator_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nDecorator Design Pattern\n");

            var personalCar = new PersonalCar { Maker = "BMW", Model = "3.2", HirePrice = 2000};

            SpecialOffer specialOffer = new SpecialOffer(personalCar);
            specialOffer.DiscountPercentage = 10; //%10

            Console.WriteLine("Orinary : " + personalCar.HirePrice);
            Console.WriteLine("Special Offer : " + specialOffer.HirePrice);

            Console.WriteLine("\n**************************************************");
        }
    }
}
