﻿using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();

        Movie GetById(int id);
        void Add(Movie movie);
        void Delete(Movie movie);
    }
}
