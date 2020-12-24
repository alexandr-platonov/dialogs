namespace Dialogs.Domain.Models.KinoRating
{
    public class Film
    {
        public Film(string title, string imdbRating)
        {
            Title = title;
            ImdbRating = imdbRating;
        }

        public string Title { get; }
        public string ImdbRating { get; }
    }
}