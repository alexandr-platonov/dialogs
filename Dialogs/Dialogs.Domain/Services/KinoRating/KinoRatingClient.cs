using System.Collections.Generic;
using Dialogs.Domain.Interfaces.KinoRating;
using Dialogs.Domain.Models.KinoRating;
using Dialogs.Domain.Services.Alisa;

namespace Dialogs.Domain.Services.KinoRating
{
    public class KinoRatingClient : AlisaClient<List<SearchFilm>, IKinoRatingDialog>, IKinoRatingClient
    {
        public KinoRatingClient(IKinoRatingDialog dialog) : base(dialog)
        {
        }
    }
}