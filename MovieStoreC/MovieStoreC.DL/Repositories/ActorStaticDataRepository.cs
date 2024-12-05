using MovieStoreC.DL.Interfaces;
using MovieStoreC.DL.StaticData;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Repositories
{
    public class MovieStaticDataRepository : IMovieRepository
    {
        public void Add(Actor actor)
        {
            StaticDb.Actors.Add(actor);
        }
        public void DeleteActors(int id)
        {
            StaticDb.Actors.Remove();
        }

        public void Delete(Actor actor)
        {
            throw new NotImplementedException();
        }

        public List<Actor> GetAllActors()
        {
            return StaticDb.actor;
        }
        public Actor? GetByIdActors(int id)
        {
            if (id <= 0) return null;
            return StaticDb.Actors.FirstOrDefault(x => x.Id == id);
        }
    }
}
