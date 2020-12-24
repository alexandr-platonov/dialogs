using System.Collections.Generic;
using Dialogs.Domain.Interfaces.Alisa;
using Dialogs.Domain.Models.KinoRating;

namespace Dialogs.Domain.Interfaces.KinoRating
{
    public interface IKinoRatingClient : IAlisaClient<List<SearchFilm>>
    {

    }
}