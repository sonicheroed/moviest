using MovieSStore.BizLayer.Interfaces;
using MovieSStore.DataLayer.Interfaces;
using MovieSStore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSStore.BizLayer.Services
{
    internal class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {  
            _movieRepository = movieRepository; 
        }

        public List<Movie> GetMovies()
        {  
            return _movieRepository.GetMovies();
        }
    }
}
