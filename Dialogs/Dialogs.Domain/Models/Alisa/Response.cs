namespace Dialogs.Domain.Models.Alisa
{
    public class Response
    {
        public Response(string text, string debug, bool endSession)
        {
            Text = text;
            Debug = debug;
            EndSession = endSession;
        }

        public string Text { get; }

        public string Debug { get; }

        public bool EndSession { get; }
    }
}