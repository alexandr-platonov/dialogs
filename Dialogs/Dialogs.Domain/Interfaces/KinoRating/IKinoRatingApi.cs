using System.Threading.Tasks;
using Dialogs.Domain.Models.KinoRating;

namespace Dialogs.Domain.Interfaces.KinoRating
{
    public interface IKinoRatingApi
    {
        Task<SearchFilmsResponse> SearchFilmsByNameAsync(string name);
        Task<KinoRatingResponse> GetFilmByIdAsync(string id);
    }
}