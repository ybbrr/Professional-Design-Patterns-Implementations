using DesignPatterns.Proxy;
using System.Diagnostics;

namespace Apps.Implementations
{
    public static class ProxyImplementation
    {
        public static void Proxy_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nProxy Design Pattern\n");

            CreditBase creditBase = new CreditManagerProxy();

            Stopwatch st = new Stopwatch();

            st.Start();
            Console.WriteLine("Result : " + creditBase.Calculate());
            st.Stop();
            Console.WriteLine("1. Calculation time : " + st.ElapsedMilliseconds + "ms");

            st.Restart();
            st.Start();
            Console.WriteLine("Result : " + creditBase.Calculate());
            st.Stop();
            Console.WriteLine("2. Calculation time : " + st.ElapsedMilliseconds + "ms");

            Console.WriteLine("\n**************************************************");
        }
    }
}
