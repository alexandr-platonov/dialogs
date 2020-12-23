namespace Dialogs.Domain.Models.Alisa
{
    public class AlisaClientRequest<T>
    {
        public AlisaClientRequest(Session session, Request request, State<T> state, string version)
        {
            Session = session;
            Request = request;
            State = state;
            Version = version;
        }

        public Session Session { get; }

        public Request Request { get; }

        public State<T> State { get; }

        public string Version { get; }
    }
}
