namespace DesignPatterns.State
{
    /*
      * State Design Pattern Bir nesnenin mevcut durumunu kontrol etmek için kullanılır.
        Bir müzik çaların durumları buna örnek olabilir, play, pause, halted gibi.
    */
    public interface IState
    {
        void DoAction(Context context);
    }

    /*
      * IState'i kullanarak istediğiniz kadar state tanımlayabilirsiniz.
    */

    public class ModifiedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State : Modified");
            context.SetState(this);
        }
    }

    public class DeletedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State : Deleted");
            context.SetState(this);
        }
    }

    public class AddedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State : Added");
            context.SetState(this);
        }
    }

    public class Context
    {
        private IState _state;

        public void SetState(IState state)
        {
            _state = state;
        }

        public IState GetState()
        {
            return _state;
        }
    }
}
