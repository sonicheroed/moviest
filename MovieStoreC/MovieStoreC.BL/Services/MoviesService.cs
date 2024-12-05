using MovieStoreC.BL.Interfaces;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.DL.StaticData;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.BL.Services
{
    internal class MoviesService : IBusinessService
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public List<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }
        public void Add(Movie movie)
        {
            StaticDb.Movies.Add(movie);
        }

        public Movie? GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
