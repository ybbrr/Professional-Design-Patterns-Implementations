using DesignPatterns.State;

namespace Apps.Implementations
{
    public static class StateImplementation
    {
        public static void State_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nState Design Pattern\n");

            Context context = new Context();
            ModifiedState modifiedState = new ModifiedState();
            modifiedState.DoAction(context);
            Console.WriteLine(context.GetState());

            DeletedState deletedState = new DeletedState();
            deletedState.DoAction(context);
            Console.WriteLine(context.GetState());

            Console.WriteLine("\n**************************************************");
        }
    }
}
