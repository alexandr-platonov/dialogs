namespace Dialogs.Domain.Models.KinoRating
{
    public class SearchFilm
    {
        public SearchFilm(string title, string year, string id, string type, string poster)
        {
            Title = title;
            Year = year;
            Id = id;
            Type = type;
            Poster = poster;
        }

        public string Title { get; }
        public string Year { get; }
        public string Id { get; }
        public string Type { get; }
        public string Poster { get; }
    }
}