using DesignPatterns.Memento;

namespace Apps.Implementations
{
    public static class MementoImplementation
    {
        public static void Memento_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nMemento Design Pattern\n");

            Book book = new Book { Title = "Computer Programming", Author = "John Doe", Isbn = "129031290381902" };
            Console.WriteLine("***Before Changes***");
            Console.WriteLine(book);

            CareTaker history = new CareTaker();
            history.memento = book.CreateUndoPoint();

            Thread.Sleep(1000);

            book.Isbn = "000000000";
            book.Title = "Jane Doe";
            Console.WriteLine("\n***After Changes***");
            Console.WriteLine(book);

            book.RestoreFromUndoPoint(history.memento);
            Console.WriteLine("\n***After Undo***");
            Console.WriteLine(book);

            Console.WriteLine("\n**************************************************");
        }
    }
}
