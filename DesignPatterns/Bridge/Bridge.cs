namespace DesignPatterns.Bridge
{
    /*
      * Bridge Design Pattern'de amaç bir nesnenin içinde soyutlanablir, diğer bir deyişle değiştirilebilir,
        switch edilebilir kısımlar varsa onları soyutlama teknikleriyle gerçekleştirip kullanmaktır.
      * Aşağıda mesaj gönderme işlemlerinin gerçekleştirileceği adında bir class olsun.
        Bu class SmS veya Email vasıtasıyla mesaj gibi işlemleri gerçekleştirecektir.
    */
    public abstract class MessageSenderBase
    {
        public void Save()
        {
            /*Burada gönderilen SmS'lerin veya Email'lerin kayını tutan bir kod olduğunu farzedin.*/
            Console.WriteLine("Message Saved. (imitation)");
        }

        /*
          * Normalde bu class abstract olmayabilirdi ve bu class'ın içinde SmS ve Email göndermekle sorumlu
            SendSmS() ve SendEmail() gibi metodlar olabilirdi. Ama özünde SmS gödnermekte Email göndermek de bir mesaj gönderme eylemidir.
            O yüzden bu class abstrct yapılmıştır ve Send() adıyla genel bir mesaj gmnderme fonksiyonu tanımlanmıştır.
            Burada amaç Send() fonksiyonuna SmS veya Email gönderme işlemi Bridge yöntemi ile
            bir anlamda injection yaprak gerçekleştirmektir.
        */

        public abstract void Send(Body messageBody);
    }

    /*
      * Aşağıdaki Body class'ı mesaj gövdesini tanımlamak için kullanılmıştır.
    */
    public class Body
    {
        public string Title { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return $"\n\nTitle : {Title,-5}\n Text : {Text, -5}\n\n";
        }
    }

    /*
      * "MessageSenderBase" class'ının soyutlanmasıyla diğer bir deyişle abstract yapılmasıyla
        bu class'ın artık concrete class'larına ihtiyaç duyulmuştur.
      * Concrete class, abstract class'ın içindeki tüm özellikleri implemente eden class'tır.
      * Burada sender türü tanımlamak için iki tane conrete class tanımlanmıştır ama gelecekte
        daha farklı türlerde de mesaj gönderme ihityacı duyulduğunda yeni conrete class'lar üretilebilir.
        Nesne yönelimli programlamnın bunu sağlar.
    */

    public class SmSSender : MessageSenderBase
    {
        public override void Send(Body messageBody)
        {
            Console.WriteLine(messageBody + "The SmS above sent via SmsSender.");
        }
    }

    public class EmailSender : MessageSenderBase
    {
        public override void Send(Body messageBody)
        {
            Console.WriteLine(messageBody + "The Email above sent via EmailSender.");
        }
    }

    /*
      * CustomerManager'ın içinde bir mesaj göndermeye çalışılacaktır.
    */

    public class CustomerManager
    {
        /*
          * Köprüleme için aşağıdaki property kullanılacaktır. Programın ilgili yerlerinde bu property'e erişilerek
            yukarıda tanımlanan SmSSender veya SmSSender class'larından biri new'lenecektir buna.
        */
        public MessageSenderBase messageSenderBase { get; set; }
        public void UpdateCustomer()
        {
            /*
              * Şimdi bu metodun içidne aşağıdaki gibi bir nesne tanımlanarak bu iş halledilebilirdi ama bu
                o nesneye bağımlılık yaratacağı için çok kötü bir programlama yöntemidir.

                --> SmSSender smsSender = nwe SmSSender();
                    smsSender.Send(new Body());

                Peki ya Email yöndermemiz gerekiyors? "if" komutu mu yazılacak? Her yeni sender class'ı için
                bir "if" komutu yazılarak bu işin içinden çıkılamaz.
              * Tüm bunların yerine bir tane Bridge oluşturlacaktır. Yukarıda property olarak MessageSenderBase çağırılmıştır.
                MessageSenderBase abstract class'dan oluşturulan bu property kullanılacaktır. 
                
            */
            messageSenderBase.Send(new Body { Title = "\"BridgeDesignPattern\"", Text = "\"In this code, Bridge Design Pattern has implemented.\"" });
            Console.WriteLine("Customer Updated.");
        }
    }
}
