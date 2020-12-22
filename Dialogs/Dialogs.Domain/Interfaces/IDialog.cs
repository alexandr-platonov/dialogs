using System.Threading.Tasks;

namespace Dialogs.Domain.Interfaces
{
    public interface IDialog<in TRequest, TResponse>
    {
        Task<TResponse> Ask(TRequest request);
    }
}