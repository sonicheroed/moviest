using MovieSStore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSStore.BizLayer.Interfaces
{
    public interface IMovieService
    {
        List<Movie> GetMovies();

        void AddMovie(Movie movie);

        void DeleteMovie(int id);

        List<Movie> GetMoviesByID(int id);
    }
}
