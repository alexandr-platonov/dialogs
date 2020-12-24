namespace Dialogs.Domain.Models.Alisa
{
    public class AlisaClientResponse<T>
    {
        public AlisaClientResponse (Response response, AlisaSaveData<T> sessionState, string version)
        {
            Response = response;
            SessionState = sessionState;
            Version = version;
        }

        public Response Response { get; } 
        
        public AlisaSaveData<T> SessionState { get; }

        public string Version { get; }
    }
}