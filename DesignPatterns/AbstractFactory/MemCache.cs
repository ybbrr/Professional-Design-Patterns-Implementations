namespace DesignPatterns.AbstractFactory
{
    public class MemCache : Caching
    {
        public override void Cache(string data)
        {
            /*Burada MemCache kodu yazdığını farzedin.*/
            Console.WriteLine(data + " Cached with MemCache. (imitation)");
        }
    }
}
