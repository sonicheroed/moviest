﻿using MovieStoreB.Models.DTO;

namespace MovieStoreB.DL.Interfaces
{
    public interface IActorRepository
    {
        Actor? GetById(int id);
    }
}
