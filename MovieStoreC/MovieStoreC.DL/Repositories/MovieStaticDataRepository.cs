using MovieStoreC.DL.Interfaces;
using MovieStoreC.DL.StaticData;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Repositories
{
    internal class MovieStaticDataRepository : IMovieRepository
    {
        public void Add(Movie movie)
        {
            StaticDb.Movies.Add(movie);
        }
        public void Delete(int id)
        {
            StaticDb.Movies.Remove();
        }

        public void Delete(Movie movie)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAll()
        {
            return StaticDb.Movies;
        }
        public Movie? GetById(int id)
        {
            if (id <= 0) return null;
            return StaticDb.Movies.FirstOrDefault(x=> x.Id == id);
        }
    }
}
