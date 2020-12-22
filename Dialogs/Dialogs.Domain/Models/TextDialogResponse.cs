namespace Dialogs.Domain.Models
{
    public class TextDialogResponse<T>
    {
        public TextDialogResponse(T answer, string answerText)
        {
            AnswerText = answerText;
            Answer = answer;
        }

        public string AnswerText { get; }

        public T Answer { get; }
    }
}