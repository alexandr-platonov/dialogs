namespace Dialogs.Domain.Models.Alisa
{
    public class Nlu
    {
        public Nlu(string[] tokens)
        {
            Tokens = tokens;
        }

        public string[] Tokens { get; }
    }
}