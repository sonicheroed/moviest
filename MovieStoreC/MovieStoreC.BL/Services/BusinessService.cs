﻿using MovieStoreC.BL.Interfaces;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.Models.DTO;
using MovieStoreC.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreC.BL.Services
{
    internal class BusinessService : IBusinessService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IActorRepository _actorRepository;

        public BusinessService(
            IMovieRepository movieRepository,
            IActorRepository actorRepository)
        {
            _movieRepository = movieRepository;
            _actorRepository = actorRepository;
        }
        public List<MovieFullDetailsResponse> GetAllMovies()
        {
            var result = new List<MovieFullDetailsResponse>();

            var movies = _movieRepository.GetAll();

            foreach (var movie in movies)
            {
                var detailedMovie = new MovieFullDetailsResponse()
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Year = movie.Year,
                };

                foreach (var actorId in movie.Actors)
                {
                    var actor = _actorRepository.GetById(actorId);
                    if (actor != null) continue;
                    detailedMovie.Actors.Add(actor);
                }

                result.Add(detailedMovie);
            }

            var actors = _actorRepository.GetAll();


            return result;
        }
    }
}