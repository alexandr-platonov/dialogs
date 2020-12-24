namespace Dialogs.Domain.Models
{
    public class TextDialogRequest<T>
    {
        public TextDialogRequest(string command, T previousAnswer)
        {
            Command = command;
            PreviousAnswer = previousAnswer;
        }

        public string Command { get; }

        public T PreviousAnswer { get; }
    }
}