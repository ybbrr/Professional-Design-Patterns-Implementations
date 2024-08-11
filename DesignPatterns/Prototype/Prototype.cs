namespace DesignPatterns.Prototype
{
    /*
      * Bir veri tabanındaki kişi bilgilerine bir Person class'ı oluşturduğunuzu farz edin.
        Bu Person üzerinden klonlama işlemleri yapılacaktır.
      * Klonlama yapılarak yeni bir nesne oluşturmanın maliyeti düşürülür.
      * Her zaman kullanılabilecek bir desen değildir.
    */
    public abstract class Person
    {
        /*
          * Temel nesneyi klon haline getirebilmemiz için o nesnenin soyut bir Clone() metodundan beslenmesi gerekir. 
        */
        public abstract Person Clone();
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Customer : Person
    {
        /*City, Customer'a ait bir özellik olsun.*/
        public string City { get; set; }
        public override Person Clone()
        {
            /*DOT.NET'te bu clone'lama işlemini yapcak hazır bir metod vardır.*/
            return (Person)MemberwiseClone();
        }
    }

    public class Employee : Person
    {
        /*Salary, Employee'e ait bir özellik olsun.*/
        public decimal Salary { get; set; }

        public override Person Clone()
        {
            /*DOT.NET'te bu clone'lama işlemini yapcak hazır bir metod vardır.*/
            return (Person)MemberwiseClone();
        }
    }
}
