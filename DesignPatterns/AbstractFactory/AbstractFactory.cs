namespace DesignPatterns.AbstractFactory
{
    /*
      * Abstract Factory Design Pattern'de temel olay Factory Method Design Pattern'e ek olarak birden fazla nesnenin
        kullanımının söz konusu olmasıdır. Kullanılacak söz konusu nesneler için bir mantık oluşturarak bu nesnelerin
        türetimini (new'lenmeisni) kolaylaştırmak temek amaçtır.
      * Bu projede iki farklı tekniğe ihtiyaç duyuduğunu ve projenin iş katmanında bu iki farklı tekniğin kullanılacağını
        farzedin. Loglama'ya ve Caching'e ihtiyaç duyulduğunu farzedin. Loggin de Caching de kendi içinde çeşitlenir.
        Bu projenin iş katmanında Logging yöntemleri olarak Log4Net ve NLogger, Caching yöntemleri olarak MemCache ve
        RedisCache kullanılacaktır.
    */

    /*
      * Loglamanın yapılabileceği yöntemleri türetmek için aşağıda "Logging" adında bir abstract class oluşturuldu.
        Loglama için Log4Net ve NLogger yöntemlerini kullanılcaktır.
      * Caching yapılabileceği yöntemleri türetmek için aşağıda "Caching" adında bir abstract class oluşturuldu.
        Caching için MemCache ve RedisCache yöntemlerini kullanılcaktır.
    */
    public abstract class Logging
    {
        public abstract void Log(string message);
    }

    public abstract class Caching
    {
        public abstract void Cache(string data);
    }

    /*
      * Yukarıda oluşturulan abstract class'lar sayesinde gelecekte yeni Logging ve Caching yöntemleri kullanmak istenirsa
        hiçbir sorun yaşamdan projenin iş katmanına dahil edilebilecektir.
      * Aslında Abtract Factory Design Pattern en çok iş katmanında kullanılsa da arayüz katmanı ve veri erişim katmanı 
        için de kullanılır.
    */

    /*
      * Şimdi Logging ve Caching yöntemlerimizi duruma göre üreyen diğer bir deyişle new'leyen bir fabrikaya ihtiyaç vardır.
        Aşağıdaki fabrikayı temsil eden abstract class yazılmıştır.
      * Aşağıdaki fabrika da yukarıdaki Caching ve Logging yöntemleri için tanımlanan abstract class'ların olduğu gibi
        abstract'tır. Bunun anlamı farklı türlerde fabrikalar oluşturulabilir.
        Diğer bir deyişle CrossCuttingConcernsFactory'den yeni fabrikalar türeyilebilir.
    */

    public abstract class CrossCuttingConcernsFactory
    {
        public abstract Logging CreateLogger();
        public abstract Caching CreateCaching();
    }
}
