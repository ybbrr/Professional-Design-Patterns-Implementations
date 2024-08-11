namespace DesignPatterns.AbstractFactory
{
    /*
      * Burada Factory ilgili projenin iş süreçlerini temsil etmektedir.
        Örneğin, bir iş katmanında loglama işlemlerinin yapılması, yazıcıdan çıktı alınması v.b
        Projenin iş süreçlerini birbiri ardına gelen "if" komutları ile oluşturmaktansa bu şekilde fabrika
        oluşturarak standardize edilir.
    */

    /*
      * Factory2'de ilgili iş süreci için NLogger ve MemCache gerekmektedir. 
    */
    public class Factory2 : CrossCuttingConcernsFactory
    {
        public override Logging CreateLogger()
        {
            return new NLogger();
        }
        public override Caching CreateCaching()
        {
            return new MemCache();
        }
    }
}
