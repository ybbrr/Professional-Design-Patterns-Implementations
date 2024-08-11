namespace DesignPatterns.Decorator
{
    /*
      * Decorator Design Pattern temel bir nesneye farklı koşullarda farklı anlamlar yüklemek için kullanılır.
      * Örneğin bir araba kiralama şirketisiniz ve bazı müşterileriniz için özel bir teklif tanımlamak istiyorsunuz.
        Veya bir e-ticaret sitesisiniz ve yeni müşterilerinize indirim tanımlamak istiyorsunuz, bu örneği Builder Design
        Pattern'i anlatırken kullanmıştık.
    */
    public abstract class CarBase 
    {
        public abstract string Maker { get; set; }
        public abstract string Model { get; set; }
        public abstract double HirePrice { get; set; }

    }

    public class PersonalCar : CarBase
    {
        public override string Maker { get; set; }
        public override string Model { get; set; }
        public override double HirePrice { get; set; }
    }

    public class CommercialCar : CarBase
    {
        public override string Maker { get; set; }
        public override string Model { get; set; }
        public override double HirePrice { get; set; }
    }

    public abstract class CarDecoratorBase : CarBase
    {
        private CarBase _carBase;

        protected CarDecoratorBase(CarBase carBase)
        {
            _carBase = carBase;
        }
    }

    /*
      * Artık özel teklifiniz için tanımlamak istediğiniz her özelliği bu class'ın içine eklemelisiniz.
        Örneğin burada indirim oranı özelliği eklenmiştir.
    */

    public class SpecialOffer : CarDecoratorBase
    {
        public double DiscountPercentage { get; set; }
        private readonly CarBase _carBase;
        
        public SpecialOffer(CarBase carBase) : base(carBase)
        {
            _carBase = carBase;
        }

        public override string Maker { get; set; }
        public override string Model { get; set; }
        public override double HirePrice { get { return _carBase.HirePrice * (100 - DiscountPercentage) / 100; } set {  } }
    }
}
