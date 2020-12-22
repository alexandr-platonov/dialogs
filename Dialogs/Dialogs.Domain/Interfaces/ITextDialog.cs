using Dialogs.Domain.Models;

namespace Dialogs.Domain.Interfaces
{
    public interface ITextDialog<T> : IDialog<TextDialogRequest<T>, TextDialogResponse<T>>
    {

    }
}