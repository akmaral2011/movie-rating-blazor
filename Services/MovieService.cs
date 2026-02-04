using MovieRatingBlazor.Models;

namespace MovieRatingBlazor.Services
{
    public class MovieService
    {
        private List<Movie> _movies = new()
        {
            new Movie { Id = 1, Title = "Остров проклятых", Description = "Психологический триллер.", Image = "/images/shutter_island.jpg" },
            new Movie { Id = 2, Title = "Форрест Гамп", Description = "Добрая история простого человека.", Image = "/images/forrest_gump.jpg" },
            new Movie { Id = 3, Title = "Зелёная миля", Description = "Трогательная история о чуде.", Image = "/images/green-mile.jpg" },
            new Movie { Id = 4, Title = "Побег из Шоушенка", Description = "История надежды и свободы.", Image = "/images/shawshank.jpg" },
            new Movie { Id = 5, Title = "Интерстеллар", Description = "Космическая драма о времени.", Image = "/images/interstellar.jpg" },
            new Movie { Id = 6, Title = "Джентльмены", Description = "Стильная криминальная комедия.", Image = "/images/gentlemen.jpg" }
        };

        public List<Movie> GetMovies() => _movies;
    }
}