using System.Text;

namespace Dialogs.Domain.Models.Alisa
{
    public class Response
    {
        public Response(string text, object debug = null)
        {
            Text = text;
            Debug = debug;
        }

        public string Text { get; }
        public object Debug { get; }
    }
}