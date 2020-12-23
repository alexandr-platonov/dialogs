namespace Dialogs.Domain.Models.Alisa
{
    public class AlisaClientResponse<T>
    {
        public AlisaClientResponse(Session session, Response response, T sessionState, string version)
        {
            Session = session;
            Response = response;
            SessionState = sessionState;
            Version = version;
        }

        public Session Session { get; }

        public Response Response { get; } 
        
        public T SessionState { get; }

        public string Version { get; }
    }
}