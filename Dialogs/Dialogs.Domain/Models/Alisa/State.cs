namespace Dialogs.Domain.Models.Alisa
{
    public class State<T>
    {
        public State(T session)
        {
            Session = session;
        }

        public T Session { get; }
    }
}