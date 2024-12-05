using MovieSStore.Models.DTO;

namespace MovieSStore.DataLayer.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetMovies();
    }
}
