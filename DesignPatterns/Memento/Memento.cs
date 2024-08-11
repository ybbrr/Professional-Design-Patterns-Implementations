namespace DesignPatterns.Memento
{
    /*
      * Memento Design Pattern ihtiyaç dahilinde kullanılır.
        Memento Design Pattern bir nesne değişikliğe uğradıktan sonra arzu edildiğinde değişkiliğe uğramamış haline dönemesini sağlar.
      * Örnek olarak bir ekranda değişiklikler yaptıktan sonra o değişiklikleri geri almayı istediğinizi farzedin.
    */
    public class Book
    {
        /*Memento Design Pattern'inde encapsulation yöntemlerinden yararlanılır.*/
        private string _title;
        private string _author;
        private string _isbn;
        private DateTime _lastEdited;
        public string Title { get { return _title; } set { _title = value; SetLastEdited(); } }
        public string Author { get { return _author; } set { _author = value; SetLastEdited(); } }
        public string Isbn { get { return _isbn; } set { _isbn = value; SetLastEdited(); } }
        /*
          * Bu nesne içindeki her değişiklikte setter'lar içinde SetLastEdited() metodu çağrıldığı için değişiklik tarihi kaydedilmiş olacak.
        */
        private void SetLastEdited()
        {
            _lastEdited = DateTime.Now;
        }

        public Memento CreateUndoPoint()
        {
            return new Memento(_title, _author, _isbn, _lastEdited);
        }

        public void RestoreFromUndoPoint(Memento memento)
        {
            _title = memento.Title;
            _author = memento.Author;
            _isbn = memento.Isbn;
            _lastEdited = memento.LastEdited;
        }

        public override string ToString()
        {
            return $"-Book Information-\n-" +
                $"Book Name : {Title, -5}, Author : {Author,-5}, ISBN : {Isbn,-5}, Edited : {_lastEdited,-5}-";
        }
    }

    public class Memento
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public DateTime LastEdited { get; set; }

        public Memento(string title, string author, string isbn, DateTime lastEdited)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            LastEdited = lastEdited;
        }
    }

    public class CareTaker
    {
        public Memento memento { get; set; }
    }
}
