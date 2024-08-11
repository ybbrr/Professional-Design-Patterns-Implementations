//Benim Builder Design Pattern'imin dizini.
using DesignPatterns.Builder;

namespace Apps.Implementations
{
    public static class BuilderImplementation
    {
        public static void Builder_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\n---Builder Design Pattern---\n");

            Console.WriteLine("\nProduct View for New Customer\n");

            ProductDirector director = new ProductDirector();
            var builder = new NewCustomerProductBuilder();
            director.GenerateProduct(builder);
            var model = builder.GetModel();

            Console.WriteLine("Product Name : " + model.ProductName);
            Console.WriteLine("Product Id : " + model.Id);
            Console.WriteLine("Product Category Name : " + model.CategoryName);
            Console.WriteLine("Product Discounted Price : " + model.DiscountedPrice);
            Console.WriteLine("Is Discounted : " + model.DiscountApplied);
            Console.WriteLine("Product Unit Price : " + model.UnitPrice);

            Console.WriteLine("\n\nProduct View for New Customer\n");

            director = new ProductDirector();
            var builder2 = new OldCustomerProductBuilder();
            director.GenerateProduct(builder2);
            model = builder2.GetModel();

            Console.WriteLine("Product Name : " + model.ProductName);
            Console.WriteLine("Product Id : " + model.Id);
            Console.WriteLine("Product Category Name : " + model.CategoryName);
            Console.WriteLine("Product Discounted Price : " + model.DiscountedPrice);
            Console.WriteLine("Is Discounted : " + model.DiscountApplied);
            Console.WriteLine("Product Unit Price : " + model.UnitPrice);

            /*
              * Kodu çalıştırdığınızda Old custormer'a indirim yapılmadığını göreceksiniz.
            */

            Console.WriteLine("\n\n**************************************************");
        }
    }
}
