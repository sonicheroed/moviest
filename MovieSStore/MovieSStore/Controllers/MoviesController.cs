using Microsoft.AspNetCore.Mvc;
using MovieSStore.DataLayer.Interfaces;
using MovieSStore.Models.DTO;

namespace MovieStoreB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesController(
            IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _movieRepository.GetMovies();
        }
    }
}