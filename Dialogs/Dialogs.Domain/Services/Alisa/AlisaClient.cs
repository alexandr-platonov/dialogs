using System.Threading.Tasks;
using Dialogs.Domain.Interfaces;
using Dialogs.Domain.Interfaces.Alisa;
using Dialogs.Domain.Models;
using Dialogs.Domain.Models.Alisa;

namespace Dialogs.Domain.Services.Alisa
{
    public class AlisaClient<T, TDialog> : IAlisaClient<T> where TDialog : ITextDialog<T>
    {
        private TDialog _dialog;

        public AlisaClient(TDialog dialog)
        {
            _dialog = dialog;
        }

        public async Task<AlisaClientResponse<T>> Ask(AlisaClientRequest<T> alisaRequest)
        {
            var textRequest = new TextDialogRequest<T>(alisaRequest.Request.Command, alisaRequest.State.Session);
            var textResponse = await _dialog.Ask(textRequest).ConfigureAwait(false);

            var alisaResponse = new AlisaClientResponse<T>
            {
                Version = alisaRequest.Version,
                Session = alisaRequest.Session,
                Response = new Response
                {
                    Text = textResponse.AnswerText,
                    EndSession = false
                },
                SessionState = textResponse.Answer
            };

            return alisaResponse;
        }
    }
}