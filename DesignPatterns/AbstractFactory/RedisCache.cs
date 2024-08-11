namespace DesignPatterns.AbstractFactory
{
    public class RedisCache : Caching
    {
        public override void Cache(string data)
        {
            /*Burada RedisCache kodu yazdığını farzedin.*/
            Console.WriteLine(data + " Cached with RedisCache. (imitation)");
        }
    }
}
