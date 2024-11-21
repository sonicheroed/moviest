using Microsoft.AspNetCore.Mvc;
using MovieStoreC.BL.Interfaces;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesService _moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Movie> GetAll()
        {
            return _moviesService.GetAll();
        }

        [HttpGet("GetById")]
        public Movie? Get(int id)
        {
            return _moviesService.GetById(id);
        }

        [HttpGet("Add")]
        public void Add(movie)
        {
            _moviesService.Add(movie);

        }
    }
}
