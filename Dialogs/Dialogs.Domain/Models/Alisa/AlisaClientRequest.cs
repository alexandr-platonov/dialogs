namespace Dialogs.Domain.Models.Alisa
{
    public class AlisaClientRequest<T>
    {
        public AlisaClientRequest(Request request, State<T> state, string version)
        {
            Request = request;
            State = state;
            Version = version;
        }

        public Request Request { get; }

        public State<T> State { get; }

        public string Version { get; }
    }
}
