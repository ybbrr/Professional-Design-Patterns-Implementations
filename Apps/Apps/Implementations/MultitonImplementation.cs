using DesignPatterns.Multiton;

namespace Apps.Implementations
{
    public static class MultitonImplementation
    {
        public static void Multiton_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nMultiton Design Pattern\n");

            Camera camera1 = Camera.GetInstance("NIKON");
            Camera camera2 = Camera.GetInstance("NIKON");
            Camera camera3 = Camera.GetInstance("CANON");
            Camera camera4 = Camera.GetInstance("CANON");

            Console.WriteLine(camera1.Id);
            Console.WriteLine(camera2.Id);
            Console.WriteLine(camera3.Id);
            Console.WriteLine(camera4.Id);

            Console.WriteLine("\n**************************************************");
        }
    }
}
