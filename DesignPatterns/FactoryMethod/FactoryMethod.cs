namespace DesignPatterns.FactoryMethod
{
    /*
      * Factory Method Design Pattern'inde en temel olay bir fabrika türümüzün olmasıdır.
      * Aşağıda Logger işlemleri yapmak için Logger nesneleri üretecek bir fabrika oluşturuldu.
    */

    /*
      * Eğer oluşturduğunuz bir class herhangi bir interface'ten ya da abtract class'tan kalıtımlanmıyorsa o class'tan biraz korkun.
        Çünkü ilerleyen zamanlarda yazılımda bir değişiklik yapmanız gerektiğinde nesnellik zafiyetleriyle karşılaşırsınız.
      * Aşağıda LoggerFactory bir ILoggerFactory interface'inden (soyut fabrikasından) soyutlanmıştır. Bu sayede gelecekte başka türlü
        logger fabrikalar ile çalışmak istediğinizde kodu yönetmeniz kolay olacaktır.
      * Örneğin, farzedin ki kendinize has özel loglama işlemlerinizi yaptığınız bir Logger'ınız var. Bu logger'ın adı "My_Own_Logger" olsun.
        Bir de Oracle veri tabanına loglama işlemlerini yaptığınız bir Logger olsun. Bu logger'ın adı da "OracleLogger" olsun.
      * Peki oluşturduğunuz logger'ları nerede kullanacaksınız? Bunun cevabı aslında basit. İhtiyacaınızın olduğu yerde kullancaksınız.
        "" isimli bir class içinde kullanacağınızı farz edin. CustomerManager ayrı bir dosyada yazılmıştır.
    */
    public class LoggerFactory : ILoggerFactory
    {
        /*
          * Burada temel bir metod vasıtasıyla loglamayı yapacak nesneyi üreten bir metod oluşturulur.
          * "Factory Method Design Pattern" ismindeki "Factory Method" aşağıdaki metoddur.
        */
        public ILogger CreateLogger()
        {
            /*
              * Burada My_Own_Logger mı türetilecek yoksa OracleLogger mı türetilecek karar vermeli.
                Diğer bir deyişle nereye Loglama yapacağınıza burada geliştireceğiniz iş ile karar versiniz.
                Örneğin, veri tabanına, metin dosyasına, json dosyasına, mail atarak loglama gibi işlemleri düşünebilirsiniz.
            */
            return new My_Own_Logger(); 
        }
    }

    /*
      * Yeri geldiğinde başka tür fabrikalarla da çalışmanız gerekecek. 
      * Farzedin ki aşağıdaki LoggerFactory2 ile de çalışmanız gerekmektedir.
      * Gördüğünmüz ise LoggerFactory2 de ILoggerFactory interface'inden kalıtılmlanmaktadır.
        Bu sayede "CreateLogger()" adlı Factory Method'un oluşturulması kesinleştirilmiştir.
    */

    public class LoggerFactory2 : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new OracleLogger();
        }
    }
}
