namespace DesignPatterns.Multiton
{
    /*
      * İsminden de anlaşılacağı üzere Sinleton'un çoklu versionudur. 
        Multiton Design Pattern'de belirli şartlar için instance'lar üretilir
        ve o şart için gerektiğinde ilgili instance'ın verilmesini sağlar.
      * Camera marklarına göre instance üretilen ve gerektiğinde ilgili camera için aynı instance'ın verildiği
        bir örnek üzerinden konu anlatılacaktır.
    */
    public class Camera
    {
        /*Burada birden fazla instace olacağı için bu instance'lar bir dictionary ile tutulacaktır.*/
        private static Dictionary<string, Camera> _cameras = new Dictionary<string, Camera>();
        private static object _lock = new object();
        public Guid Id { get; set; }
        private Camera()
        {
            Id = Guid.NewGuid(); /*her seferinde gerçekten aynı instance'ın verildiğini göstermek için bu yapıldı*/
        }

        public static Camera GetInstance(string brand)
        {
            lock (_lock)
            {
                if (!_cameras.ContainsKey(brand))
                {
                    _cameras.Add(brand, new Camera());
                }
            }

            return _cameras[brand];
        }
    }
}
