namespace Dialogs.Domain.Models.Alisa
{
    public class State<T>
    {
        public State(AlisaSaveData<T> session)
        {
            Session = session;
        }

        public AlisaSaveData<T> Session { get; }
    }
}