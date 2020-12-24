using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dialogs.Domain.Interfaces.KinoRating;
using Dialogs.Domain.Models;
using Dialogs.Domain.Models.KinoRating;

namespace Dialogs.Domain.Services.KinoRating
{
    public class KinoRatingDialog : IKinoRatingDialog
    {
        private readonly IKinoRatingApi _kinoRatingApi;

        public KinoRatingDialog(IKinoRatingApi kinoRatingApi)
        {
            _kinoRatingApi = kinoRatingApi;
        }

        public async Task<TextDialogResponse<List<SearchFilm>>> Ask(TextDialogRequest<List<SearchFilm>> request)
        {
            if (string.IsNullOrEmpty(request.Command))
            {
                return new TextDialogResponse<List<SearchFilm>>("Какой фильм вы ищете?");
            }

            if (int.TryParse(request.Command, out var number) && request.PreviousAnswer?.Count >= number)
            {
                var selectedFilm = request.PreviousAnswer[number - 1];
                return await GetFilmByIdAsync(selectedFilm).ConfigureAwait(false);
            }

            var films = await _kinoRatingApi.SearchFilmsByNameAsync(request.Command).ConfigureAwait(false);

            if (!films.IsSuccess)
            {
                return new TextDialogResponse<List<SearchFilm>>(films.Error);
            }

            if (!films.Result.Any())
            {
                return new TextDialogResponse<List<SearchFilm>>("К сожалению, я не нашла фильм по вашему запросу");
            }

            if (films.Result.Count > 1)
            {
                int i = 1;
                var filmNames = films.Result.Select(x => $"{i++}) {x.Title} ({x.Year}, {x.Type.ToLower()})");
                var joinedNames = string.Join("\n", filmNames);

                return new TextDialogResponse<List<SearchFilm>>(films.Result, $"Я нашла несколько фильмов: \n{joinedNames}. \nКакой из них?");
            }

            var searchedFilm = films.Result.Single();

            return await GetFilmByIdAsync(searchedFilm).ConfigureAwait(false);
        }

        private async Task<TextDialogResponse<List<SearchFilm>>> GetFilmByIdAsync(SearchFilm searchedFilm)
        {
            var film = await _kinoRatingApi.GetFilmByIdAsync(searchedFilm.Id);

            if (!film.IsSuccess)
            {
                return new TextDialogResponse<List<SearchFilm>>(film.Error);
            }

            return new TextDialogResponse<List<SearchFilm>>($"{film.Result.Title} имеет рейтинг {film.Result.ImdbRating}");
        }
    }
}