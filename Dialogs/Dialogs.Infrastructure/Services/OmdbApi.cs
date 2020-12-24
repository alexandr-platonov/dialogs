using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Dialogs.Domain.Interfaces.KinoRating;
using Dialogs.Domain.Models.KinoRating;
using Dialogs.Infrastructure.Models;
using Newtonsoft.Json;

namespace Dialogs.Infrastructure.Services
{
    public class OmdbApi : IKinoRatingApi
    {
        private const string ApiUrl = "http://www.omdbapi.com/?apikey=a3b70434&{0}";

        public async Task<SearchFilmsResponse> SearchFilmsByNameAsync(string name)
        {
            var result = await SendRequestAsync<SearchFilmsResponseDto>($"s={name}").ConfigureAwait(false);

            if (!string.IsNullOrEmpty(result.Error))
            {
                return new SearchFilmsResponse(result.Error);
            }

            return new SearchFilmsResponse(result.Search.Select(x => new SearchFilm(x.Title, x.Year, x.ImdbId, x.Type, x.Poster)).ToList());
        }

        public async Task<KinoRatingResponse> GetFilmByIdAsync(string id)
        {
            var filmResponse = await SendRequestAsync<FilmDto>($"i={id}").ConfigureAwait(false);

            return new KinoRatingResponse(new Film(filmResponse.Title, filmResponse.ImdbRating));
        }

        private async Task<T> SendRequestAsync<T>(string name)
        {
            var absoluteUrl = string.Format(ApiUrl, name);

            using var client = new HttpClient();
            var response = await client.GetAsync(absoluteUrl).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            await using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            using var streamReader = new StreamReader(responseStream);
            using var jsonTextReader = new JsonTextReader(streamReader);
            var serializer = JsonSerializer.Create(new JsonSerializerSettings());
            var typedBody = serializer.Deserialize<T>(jsonTextReader);
            return typedBody;
        }
    }
}
