namespace Dialogs.Domain.Models.Alisa
{
    public class Request
    {
        public Request(string originalUtterance, string command, Nlu nlu)
        {
            OriginalUtterance = originalUtterance;
            Command = command;
            Nlu = nlu;
        }

        public string OriginalUtterance { get; }

        public string Command { get; }

        public Nlu Nlu { get; }
    }
}