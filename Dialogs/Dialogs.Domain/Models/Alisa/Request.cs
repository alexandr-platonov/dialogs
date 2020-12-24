namespace Dialogs.Domain.Models.Alisa
{
    public class Request
    {
        public Request(string command)
        {
            Command = command;
        }

        public string Command { get; }
    }
}