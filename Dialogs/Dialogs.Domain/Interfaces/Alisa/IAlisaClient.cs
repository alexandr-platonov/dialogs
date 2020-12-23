using Dialogs.Domain.Models.Alisa;

namespace Dialogs.Domain.Interfaces.Alisa
{
    public interface IAlisaClient<T> : IDialog<AlisaClientRequest<T>, AlisaClientResponse<T>>
    {
    }
}
