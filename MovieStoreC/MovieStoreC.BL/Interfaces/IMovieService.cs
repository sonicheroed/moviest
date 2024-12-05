﻿using MovieStoreB.Models.DTO;

namespace MovieStoreB.BL.Interfaces
{
    public interface IMovieService
    {
        List<Movie> GetMovies();
        void AddMovie(Movie movie);
        void DeleteMovie(int id);
        Movie? GetMoviesById(int id);
    }
}
