using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Benim Abstract Factory Design Pattern'ımın dizini.
using DesignPatterns.AbstractFactory;

namespace Apps.Implementations
{
    public static class AbstractFactoryImplementation
    {
        public static void AbstractFactory_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nAbstract Factory Design Pattern\n");
                        
            ProductManager pm = new ProductManager(new Factory1());
            pm.GetAll();

            pm = new ProductManager(new Factory2());
            pm.GetAll();

            /*
              * Nesne new'lerken tek bağımlılık ProductManager class'ınadır.
            */

            Console.WriteLine("\n**************************************************");
        }
    }
}
