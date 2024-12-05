using MovieSStore.DataLayer.DataBase;
using MovieSStore.DataLayer.Interfaces;
using MovieSStore.Models.DTO;

namespace MovieSStore.DataLayer.Repositories
{
    internal class MovieRepository : IMovieRepository
    {
        public List<Movie> GetMovies()
        {
            return StaticData.Movies;
        }
        public void AddMovie(Movie movie)
        {
            var movie = 
            throw new NotImplementedException();
        }

        public void DeleteMovie(int id)
        {
            if()
            throw new NotImplementedException();
        }
        public Movie? GetMovieById(int id)
        {
            return StaticData.Movies.First(x => x.Id == id);
        }
    }
}
