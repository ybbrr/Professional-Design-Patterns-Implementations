namespace DesignPatterns.AbstractFactory
{
    /*
      * Burada Factory ilgili projenin iş süreçlerini temsil etmektedir.
        Örneğin, bir iş katmanında loglama işlemlerinin yapılması, yazıcıdan çıktı alınması v.b
        Projenin iş süreçlerini birbiri ardına gelen "if" komutları ile oluşturmaktansa bu şekilde fabrika
        oluşturarak standardize edilir.
    */

    /*
      * Factory1'de ilgili iş süreci için Log4NetLogger ve RedisCache gerekmektedir. 
    */
    public class Factory1 : CrossCuttingConcernsFactory
    {
        public override Logging CreateLogger()
        {
            return new Log4NetLogger();
        }
        public override Caching CreateCaching()
        {
            return new RedisCache();
        }
    }
}
