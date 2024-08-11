//Benim Singleton Desing Pattern'imin dizini.
using DesignPatterns.SingletonDesignPattern;

namespace Apps.Implementations
{
    public static class SingletonImplementations
    {
        public static void Singleton_Thread_Safe()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nSingleton Design Pattern (Thread Safe)\n");

            var singleton = Singleton_ThreadSafe.CreateAsSingletonThreadSafe();

            singleton.Save();
            singleton.Update();
            singleton.Delete();

            Console.WriteLine("\n**************************************************");
        }

        public static void Singleton_not_Thread_Safe()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nSingleton Design Pattern (Not Thread Safe)\n");

            var singleton = Singleton.CreateAsSingleton();

            singleton.Save();
            singleton.Update();
            singleton.Delete();

            Console.WriteLine("\n**************************************************");
        }
    }
}
